using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPrep.Objective._2_2
{
    class Listing228
    {
        internal static void DynamicDemo()
        {

            dynamic x = "Hello"; //type will be figured out at runtime, you loose type saftey when using the dynamic keyword
            dynamic i = 5; //not that intellisense has no idea what methods are available off these types.

            Console.WriteLine(x.ToString()); //calls this function blindly and trusts you that it exists.             
        }

        public static void DisplayInExcel(List<dynamic> entities)
        {
            //var excelApp = new Excel.Application();
        }
    }
}
