using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPrep.Objective._2_4
{
    class Listing247
    {
        internal static void OverridingVirtualMethod()
        {
            var derived = new Derived();

            derived.Execute();
        }
    }

    public class Base
    {
        public virtual void Execute()
        {
            Console.WriteLine("Base Execute");
        }
    }

    public class Derived : Base
    {
        public override void Execute()
        {
            Log("Before executing");
            base.Execute();
            Log("After executing");
        }

        private void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}
