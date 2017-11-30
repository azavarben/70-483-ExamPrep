using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPrep.Objective._2_4
{
    class Listing248
    {
        internal static void HidingMethodWithNewKeyword()
        {
            NewBase newBase = new NewBase();
            newBase.Execute();
            newBase = new DerivedNewBase();
            newBase.Execute();
        }
    }

    class NewBase
    {
        public void Execute()
        {
            Console.WriteLine("Base.Execute");
        }
    }

    class DerivedNewBase : NewBase
    {
        public new void Execute()
        {
            Console.WriteLine("Derived.Execute");
        }
    }
}
