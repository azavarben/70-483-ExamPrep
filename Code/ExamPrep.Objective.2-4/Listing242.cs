using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPrep.Objective._2_4
{
    class Listing242
    {
        internal static void AddingSetAccessorToInterfaceWithProps()
        {
            
        }

        public interface IReadOnly
        {
            int Value { get; }
        }

        struct ReadAndWrite : IReadOnly
        {
            public int Value { get; set; }
        }
    }
}
