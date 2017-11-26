using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPrep.Objective._2_2
{
    class Listing221
    {
        internal static void ImplicitConversionForObjectsDemo()
        {
            Dog d = new Dog();

            Animal a = d;

            var name = a.Name;
            //a.Bark(); wont work
        }
    }

    public class Animal
    {
        public string Name { get; set; }
    }

    public class Dog : Animal
    {
        public void Bark()
        {


        }
    }
}
