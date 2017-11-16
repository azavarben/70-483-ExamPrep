using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPrep.Objective._2_1
{
    class Listing29
    {
        internal static void FieldDemo()
        {
            var myClass = new MyClass();

            myClass.MyInstanceField = "Stuff";
            
            Console.WriteLine(myClass.Concatentate("ing is my favorite Thanksgiving food."));
        }
    }

    public class MyClass
    {
        public string MyInstanceField;

        public string Concatentate(string valueToAppend)
        {
            return MyInstanceField + valueToAppend;
        }
    }
}
