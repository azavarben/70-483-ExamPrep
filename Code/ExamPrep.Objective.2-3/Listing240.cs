using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPrep.Objective._2_3
{
    class Listing240
    {
        internal static void ImplementInterfaceExplicitlyAgain()
        {
            var movableObject = new MoveableObject();

            ((ILeft)movableObject).Move();
            ((IRight)movableObject).Move();
        }
    }

    interface ILeft
    {
        void Move();
    }

    interface IRight
    {
        void Move();
    }

    public class MoveableObject : ILeft, IRight
    {
        void IRight.Move()
        {
            Console.WriteLine("Moving right");
        }

        void ILeft.Move()
        {
            Console.WriteLine("Moving left");
        }
    }
}
