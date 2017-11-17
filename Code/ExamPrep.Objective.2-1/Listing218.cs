using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPrep.Objective._2_1
{
    class Listing218
    {
        internal static void SealedDemo()
        {
            throw new NotImplementedException();
        }
    }

    public class AnotherBase
    {
        public virtual int MyMethod()
        {
            return 42;
        }
    }

    public class AnotherDerived : AnotherBase
    {
        public sealed override int MyMethod()
        {
            return base.MyMethod() * 42;
        }
    }

    public class DerivedAgain : AnotherDerived
    {
        //compiler error
        //public override int MyMethod()
        //{

        //}
    }
}
