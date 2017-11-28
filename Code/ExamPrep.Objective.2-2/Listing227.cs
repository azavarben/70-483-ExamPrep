using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPrep.Objective._2_2
{
    class Listing227
    {
        internal static void UsingIsAndAsOperators()
        {
            Animal a = new Animal();

            if (a is Dog)
            {
                Dog d = (Dog)a; //runtime error without check
            }




            Dog d1 = new Dog();

            Animal a1 = d1;

            //using is, is inefficeint because we are type checking twice
            if (a1 is Dog)
            {
                Dog d2 = (Dog)a1;

                Console.WriteLine("a1 is a Dog");
            }

            //typechecking is only done once using the as keyword
            Animal a2 = new Animal();
            Dog d3 = a2 as Dog;

            if (d3 != null)
            {
                d3.Bark();
            } else
            {
                Console.WriteLine("not a dog");
            }


        }
    }
}
