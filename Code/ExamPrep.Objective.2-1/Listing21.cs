using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPrep.Objective._2_1
{
    [Flags]
    public enum Days //: byte, msdn recommends using an int32
    {
        Saturday = 1,
        Sunday = 2,
        Monday = 4,
        Tuesday = 8,
        Wednesday = 16,
        Thursday = 32,
        Friday = 64,
        //Smonday = 128,
        //Thruseday = 256
    }

    class Listing21
    {
        public static void EnumDemo()
        {
            var myDay = Days.Friday;

            //Console.WriteLine((int)myDay);

            var readingDays = Days.Saturday | Days.Sunday;

            Console.WriteLine("Flags: {0}", readingDays.ToString());

            var dotNetDaysEnum = DayOfWeek.Friday | DayOfWeek.Saturday;

            Console.WriteLine("No Flags: {0}", dotNetDaysEnum.ToString());
        }
    }
}
