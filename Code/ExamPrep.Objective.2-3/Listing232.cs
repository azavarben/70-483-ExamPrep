using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPrep.Objective._2_3
{
    class Listing232
    {
        internal static void PrivateAccessModifierDemo()
        {
            
        }
    }

    public class Accessiblity
    {
        private string _myField;

        public string MyProperty
        {
            get
            {
                return _myField;
            }

            set
            {
                _myField = value;
            }
        }

        private string[] _myOtherField;

        public string MyOtherProperty
        {
            get
            {
                return _myOtherField[0];
            }

            set
            {
                _myOtherField[0] = value;
            }
        }
    }
}
