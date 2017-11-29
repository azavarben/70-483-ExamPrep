using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPrep.Objective._2_3
{
    class Listing234
    {
        internal static void ProtectedAccessModifierWithInheritanceDemo()
        {
            throw new NotImplementedException();
        }
    }

    public class Base
    {
        private int _privateField = 42;
        protected int _protectedField = 42;

        private void MyPrivateMethod() { }
        protected void MyProtectedMethod() { }
    }

    public class Derived : Base
    {
        public void MyDerivedMethod()
        {
            //_privateField = 41; inaccessible
            _protectedField = 43;

            //MyPrivateMethod(); inaccessible
            MyProtectedMethod();
        }
    }
}
