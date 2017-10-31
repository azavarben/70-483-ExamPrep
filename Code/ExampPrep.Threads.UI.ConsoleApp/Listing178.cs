using System;
using System.IO;

namespace ExampPrep.Threads.UI.ConsoleApp
{
    internal class Listing178
    {
        internal static void Contravariance()
        {
            var contra = new Contravariance();
        }
    }

    internal class Contravariance
    {
        public delegate void ContravarianceDel(StreamWriter writer);

        public Contravariance()
        {
            ContravarianceDel d;

            d = TextMethod;

            //when passing a method to the delegate, something more general 
            //will work because the type in the sig inherits from the the type being passed in.
        }

        public void TextMethod(TextWriter writer)
        {

        }
    }
}