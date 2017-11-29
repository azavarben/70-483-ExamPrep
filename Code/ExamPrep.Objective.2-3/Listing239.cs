using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPrep.Objective._2_3
{
    class Listing239
    {
        internal static void ImplementInterfaceExplicitly()
        {
            Implementation impl = new Implementation();

            ((IInterfaceA)impl).MyMethod(); //have to cast to call the method, can be useful to hide members of a class to outside members
        }
    }

    interface IInterfaceA
    {
        void MyMethod();
    }

    public class Implementation : IInterfaceA
    {
        void IInterfaceA.MyMethod()
        {
            throw new NotImplementedException();
        }
    }
}
