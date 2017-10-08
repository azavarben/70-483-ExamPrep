using ExampPrep.Tasks;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExampPrep.UI.WinForms
{
    public partial class Form1 : Form
    {
        private PersonRepo _personRepo;
        private CancellationTokenSource _cancellationTokenSource;

        public Form1()
        {
            InitializeComponent();

            _personRepo = new PersonRepo();

            listBox1.DisplayMember = "Name";
        }

        private void GetWithTask_Click(object sender, EventArgs e)
        {
            _cancellationTokenSource = new CancellationTokenSource();
            btnGetWithTask.Enabled = false;
            btnCancel.Enabled = true;

            ClearListBox();

            Task<List<Person>> peopleTask = _personRepo.Get(_cancellationTokenSource.Token);
            peopleTask.ContinueWith(t =>
            {
                switch (t.Status)
                {
                    case TaskStatus.RanToCompletion:

                        List<Person> people = t.Result;

                        foreach (var person in people)
                        {
                            listBox1.Items.Add(person);
                        }
                        break;
                    case TaskStatus.Canceled:
                        MessageBox.Show("Operation has been cancelled", "Cancelled");
                        break;
                    case TaskStatus.Faulted:

                        var allInnerExceptions = t.Exception.Flatten().InnerExceptions; //takes all the aggregate exceptions that may have happened an flattens them down

                        foreach (var innerException in allInnerExceptions)
                        {
                            MessageBox.Show(innerException.Message, "There was a problemo.");
                        }
                        break;
                }

                btnGetWithTask.Enabled = true;
                btnCancel.Enabled = false;

            },
            //CancellationToken.None,
            //TaskContinuationOptions.OnlyOnRanToCompletion, //continuation will only run if the task completed, its not faulted and it was not cancelled
            TaskScheduler.FromCurrentSynchronizationContext()); //will not run until after the first task has been completed

            //want this coninuation, enabling the button, to always run, regardless of if it failed or not
            //this is why no coninuation options are specified
            //peopleTask.ContinueWith(t =>
            //{
            //    btnGetWithTask.Enabled = true;
            //}, TaskScheduler.FromCurrentSynchronizationContext());


            //only want this continuation to run if we have a faulted task
            //peopleTask.ContinueWith(t =>
            //{
            //    var allInnerExceptions = t.Exception.Flatten().InnerExceptions; //takes all the aggregate exceptions that may have happened an flattens them down

            //    foreach (var innerException in allInnerExceptions)
            //    {
            //        MessageBox.Show(innerException.Message, "There was a problemo.");
            //    }
            //},
            //CancellationToken.None,
            //TaskContinuationOptions.OnlyOnFaulted,
            //TaskScheduler.FromCurrentSynchronizationContext());
        }

        /// <summary>
        /// Simpler to use the await syntax, compiler handles the continue with and contexts
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void GetWithAsync_Click(object sender, EventArgs e)
        {
            _cancellationTokenSource = new CancellationTokenSource();
            btnCancel.Enabled = true;
            btnGetWithAsync.Enabled = false; //prevents clicking the button multiple times and returning multiple sets

            try
            {
                ClearListBox();

                List<Person> people = await _personRepo.Get(_cancellationTokenSource.Token); //pauses the method until the Task<List<Person>> returns

                foreach (var person in people)
                {
                    listBox1.Items.Add(person);
                }
            }
            catch (OperationCanceledException ex)
            {
                MessageBox.Show(ex.Message, "Cancelled");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "There was a problemo");
            }
            finally
            {
                btnGetWithAsync.Enabled = true; //renable the button, even if somethine went wrong
                btnCancel.Enabled = false;
            }
        }

        /// <summary>
        /// Clears items in list box, duh
        /// </summary>
        private void ClearListBox()
        {
            listBox1.Items.Clear();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            _cancellationTokenSource.Cancel();
            btnCancel.Enabled = false;
        }
    }
}
