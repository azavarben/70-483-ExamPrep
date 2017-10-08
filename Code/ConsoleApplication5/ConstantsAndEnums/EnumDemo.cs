using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampPrep.ConstantsAndEnums
{
    /// <summary>
    /// Enumerations start at 0 by default
    /// </summary>
    public class EnumDemo
    {
        enum Temperatures
        {
            ReallyCold, //defaults to 0
            Freezing = 32,
            OneAboveFreezing, //would be 33
        }

        /// <summary>
        /// Enums by default are backed by integers, can use other numeric types
        /// </summary>
        enum TempsBelow255 : byte
        {
            OneDegree = 1,
            TwoDegrees = 2
        }

        public void DoStuff(int temp)
        {
            if (temp > (int)Temperatures.Freezing)
            {

            }
        }
    }
}
