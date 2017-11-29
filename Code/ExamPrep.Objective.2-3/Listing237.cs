using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPrep.Objective._2_3
{
    class Listing237
    {
        internal static void CreatingPropertyDemo()
        {
            
        }
    }

    public class NormalClass
    {
        private string _firstName;

        public string FirstName
        {
            get { return _firstName; }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException();
                }

                _firstName = value;
            }
        }
    }
}
