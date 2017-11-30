using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPrep.Objective._2_4
{
    class Listing246
    {
        internal static void InheritingFromABaseClass()
        {
            throw new NotImplementedException();
        }
    }

    class Order : IEntity
    {
        public int Id { get; }
        public decimal Amount { get; set; }
    }

    class OrderRepository : Repostiory<Order>
    {
        public OrderRepository(IEnumerable<Order> elements) : base(elements)
        {
        }

        public IEnumerable<Order> FilterOrdersOnAmount(decimal amount)
        {
            return _elements.Where(o => o.Amount > amount);
        }
    }
}
