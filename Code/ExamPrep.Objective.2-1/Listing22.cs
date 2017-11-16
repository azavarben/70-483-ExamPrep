using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPrep.Objective._2_1
{
    class Listing22
    {
        internal static void StructDemo()
        {
            var point = new Point(10, 4);
        }

    }

    //value types such as structs are stored on the stack, unmanaged / not garbage collected
    //their values are assigned directly to them, vs reference types which is a pointer to the location in memory
    //url is a refernece to a web page, value type equivalent would be printing out the page 
    public struct Point //: GopherStyleUriParser, strucs can also not inherit from any classes
    {
        public int x { get; set; }
        public int y { get; set; }

        //structs cannot have empty ctors
        //public Point()
        //{

        //}

        public Point(int p1, int p2)
        {
            x = p1;
            y = p2;
        }
    }
}
