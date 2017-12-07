using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPrep.Objective._2_4
{
    class Listing254
    {
        internal static void ImplementingIComparable()
        {
            List<ComparableOrder> orders = new List<ComparableOrder>();

            orders.Add(new ComparableOrder { Created = new DateTime(2012, 12, 1) });
            orders.Add(new ComparableOrder { Created = new DateTime(2012, 1, 6) });
            orders.Add(new ComparableOrder { Created = new DateTime(2012, 7, 8) });
            orders.Add(new ComparableOrder { Created = new DateTime(2012, 2, 20) });

            orders.Sort();

            foreach (var order in orders)
            {
                Console.WriteLine(order);
            }
        }
    }

    public class ComparableOrder : IComparable<ComparableOrder>, IComparable
    {
        public DateTime Created { get; set; }

        public int CompareTo(ComparableOrder that)
        {
            return this.Created.CompareTo(that.Created);
        }

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            ComparableOrder o = obj as ComparableOrder;

            if (o == null)
            {
                throw new ArgumentException("Object is not an order");
            }

            return this.Created.CompareTo(o.Created);
        }

        public override string ToString()
        {
            return Created.ToShortDateString();
        }
    }
}
