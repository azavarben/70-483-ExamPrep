using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPrep.Objective._2_1
{
    class Listing212
    {
        internal static void ConstructorChainingDemo()
        {
            Console.WriteLine("No args");
            var constructor = new ConstructorChaining();

            Console.WriteLine("With args");
            var constructor2 = new ConstructorChaining(4);
        }

        public class ConstructorChaining
        {
            private int _p;

            public ConstructorChaining() : this(3) 
            {
                Console.WriteLine("Default contstructor");
            }

            public ConstructorChaining(int p)
            {
                _p = p;

                Console.WriteLine("Overloaded constructor, _p = {0}", _p);

            }
        }
    }
}
