using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPrep.Objective._2_4
{
    class Listing244
    {
        internal static void InstatiateConcreteTypeThatImplementsInterface()
        {
            IAnimal animal = new Dog();

            //animal.Bark(); wont compile, must cast
        }
    }

    interface IAnimal
    {
        void Move();
    }

    class Dog : IAnimal
    {
        public void Move()
        {
            
        }

        public void Bark()
        {

        }
    }
}
