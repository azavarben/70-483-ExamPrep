using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPrep.Objective._2_1
{
    class Listing214
    {
        internal static void GenericsWhereConstraintDemo()
        {
            var myClass = new MyClass<Person>();
        }


        public class MyClass<T> where T : class, new()
        {
            public T MyProperty { get; private set; }

            public MyClass()
            {
                MyProperty = new T();
            }

        }
    }

    internal class Person
    {
    }
}
