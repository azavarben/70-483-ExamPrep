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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnDoStuff_Click(object sender, EventArgs e)
        {
            //do something, gettext
            //Task.Factory.StartNew(() => GetText("Joe"))
            //    .ContinueWith(t => label1.Text = t.Result, //continue with, updating the result, but not on a ui thread
            //TaskScheduler.FromCurrentSynchronizationContext());

            CallMethod();

            label1.Text = "Waiting...";
        }

        private async void CallMethod()
        {
            var result = await GetTextAsync("Joe"); //program will not continue beyond this line until the call has completed
            label1.Text = result;
        }

        private Task<string> GetTextAsync(string text)
        {
            return Task.Factory.StartNew(() => GetText(text));
        }

        private string GetText(string text)
        {
            Thread.Sleep(2000);

            return string.Format("Hi {0}", text);
        }
    }
}
