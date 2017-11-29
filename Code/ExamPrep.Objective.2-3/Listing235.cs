using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPrep.Objective._2_3
{
    class Listing235
    {
        internal static void InternalAccessModifierDemo()
        {
            Console.WriteLine("see unit test project and the assebly file for this project, using InternalsVisibleTo");
        }
    }

    internal class MyInternalClass
    {
        public void MyMethod() { }
    }
}
