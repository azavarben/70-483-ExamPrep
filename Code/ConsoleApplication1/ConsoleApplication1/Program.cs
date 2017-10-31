using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        public delegate void DoSomething(string message);

        static void Main(string[] args)
        {
            var person = new Person("Dude");

            Console.WriteLine(person.ToString(person.Name, s => s.ToUpper()));

            //explicit delegate
            DoSomething somethingCall;

            somethingCall = SomethingCall;

            somethingCall("from delegate");

            //using action no need for a delegate
            Action<string> doSomethingElse = SomethingCall;

            doSomethingElse("from action");

            //can use anonymous method with both
            doSomethingElse = delegate(string s) { SomethingCall(s); };

            doSomethingElse("from anon");

            doSomethingElse = s => SomethingCall(s);

            doSomethingElse("from lambda");



            List<String> names = new List<String>();
            names.Add("Bruce");
            names.Add("Alfred");
            names.Add("Tim");
            names.Add("Richard");

            // Display the contents of the list using the Print method.
            names.ForEach(Print);

            // The following demonstrates the anonymous method feature of C#
            // to display the contents of the list to the console.
            names.ForEach(delegate (String name)
            {
                Console.WriteLine(name);
            });

            names.ForEach(n => Console.WriteLine(n));

            Console.ReadLine();
        }

        private static void SomethingCall(string message)
        {
            Console.WriteLine(message);
        }

        private static void Print(string s)
        {
            Console.WriteLine(s);
        }
    }
}
