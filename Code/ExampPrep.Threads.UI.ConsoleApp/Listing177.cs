using System;
using System.IO;

namespace ExampPrep.Threads.UI.ConsoleApp
{
    internal class Listing177
    {
        internal static void Covariance()
        {
            throw new NotImplementedException();
        }
    }

    public class Covariance
    {
        public delegate TextWriter CovarianceDelegate();

        public Covariance()
        {
            CovarianceDelegate d;

            d = MethodStream;
            d = MethodString;

            //can assign both because the return types inherit from TextWriter
        }

        public StreamWriter MethodStream()
        {
            return null;
        }

        public StringWriter MethodString()
        {
            return null;
        }
    }
}