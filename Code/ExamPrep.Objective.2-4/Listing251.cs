using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPrep.Objective._2_4
{
    class Listing251
    {
        internal static void SquareClassInheritingFromRectangle()
        {
            throw new NotImplementedException();
        }
    }

    class Square : Rectangle
    {
        public override int Width
        {
            get
            {
                return base.Width;
            }

            set
            {
                base.Width = value;
                base.Height = value;
            }
        }

        public override int Height
        {
            get
            {
                return base.Height;
            }

            set
            {
                base.Height = value;
                base.Width = value;
            }
        }

        public Square(int size) : base(size, size)
        {
        }
    }
}
