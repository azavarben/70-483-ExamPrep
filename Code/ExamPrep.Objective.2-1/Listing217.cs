using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPrep.Objective._2_1
{
    class Listing217
    {
        internal static void OverridingVirtualMethodDemo()
        {
            var baseClass = new Base();

            Console.WriteLine("Base: {0}", baseClass.MyMethod());

            var derived = new Derived();

            Console.WriteLine("Derived: {0}", derived.MyMethod());
        }
    }

    public class Base
    {
        public virtual int MyMethod()
        {
            return 42;
        }
    }

    public class Derived : Base
    {
        public override int MyMethod()
        {
            return base.MyMethod() * 2;
        }
    }
}
