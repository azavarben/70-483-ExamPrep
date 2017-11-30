using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPrep.Objective._2_4
{
    class Listing249
    {
        internal static void CreatingAbstractClass()
        {
            
        }
    }

    abstract class AbstractBase
    {
        public virtual void MethodWithImplmentation()
        {

        }

        public abstract void AbstractMethod();
    }

    class DerivedFromAbstract : AbstractBase
    {
        public override void AbstractMethod()
        {
            throw new NotImplementedException();
        }
    }
}
