using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPrep.Objective._2_4
{
    class Listing250
    {
        internal static void RectangleClass()
        {
            throw new NotImplementedException();
        }
    }

    class Rectangle
    {
        public virtual int Height { get; set; }
        public virtual int Width { get; set; }

        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public int Area
        {
            get { return Height * Width; }
        }
    }
}
