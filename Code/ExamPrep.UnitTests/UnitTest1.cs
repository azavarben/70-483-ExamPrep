using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExamPrep.Objective._2_3;

namespace ExamPrep.UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            MyInternalClass myclass = new MyInternalClass();

            myclass.MyMethod();
        }
    }
}
