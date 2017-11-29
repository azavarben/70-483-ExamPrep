using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPrep.Objective._2_4
{
    class Listing241
    {
        internal static void CreatingAndImplementingInterfaceDemo()
        {
            var example = new ExampleImplementation();

            example.ResultRetreived += (sender, e) => { Console.WriteLine("Retrieved!"); };

            Console.WriteLine(example["duh"]);

        }

    }

    interface IExample
    {
        string GetResult();
        int Value { get; set; }
        event EventHandler ResultRetreived;
        int this[string index] { get; set; }
    }

    class ExampleImplementation : IExample
    {
        public int this[string index]
        {
            get
            {
                ResultRetreived(this, EventArgs.Empty);

                return 42;
            }

            set
            {
            }
        }

        public int Value { get;set; }

        public event EventHandler ResultRetreived;

        public string GetResult()
        {
            return "result";
        }
    }
}
