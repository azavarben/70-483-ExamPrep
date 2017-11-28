using System;
using System.Dynamic;

namespace ExamPrep.Objective._2_2
{
    internal class Listing229
    {
        internal static void DynamicObjectDemo()
        {
            dynamic obj = new SampleObject();

            Console.WriteLine(obj.SomeProperty);

        }    
    }

    public class SampleObject : DynamicObject
    {
        public override bool TryGetMember(GetMemberBinder binder, out object result)
        {
            result = binder.Name;

            return true;
        }
    }
}