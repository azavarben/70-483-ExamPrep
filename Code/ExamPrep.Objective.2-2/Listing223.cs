using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPrep.Objective._2_2
{
    class Listing223
    {
        internal static void ExplicitConversionForObjectsDemo()
        {
            //Animal a = new Animal();

            ////an animal is not a dog, a dog is an animal, woof.            
            //Dog d = (Dog)a; //casting this shuts up the compiler but it will blow up during runtime, invalid case exception


            Dog d = new Dog();

            Animal a = d;

            Dog d1 = (Dog)a;
        }
    }
}
