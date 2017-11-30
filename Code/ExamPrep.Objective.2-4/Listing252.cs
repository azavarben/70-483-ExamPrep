using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPrep.Objective._2_4
{
    class Listing252
    {
        internal static void UsingTheSquareClass()
        {
            Rectangle rectangle = new Square(10);
            rectangle.Width = 10;
            rectangle.Height = 5;

            Console.WriteLine(rectangle.Area);
        }
    }
}
