using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPrep.Objective._2_4
{
    class Listing245
    {
        internal static void CreatingABaseClass()
        {
            throw new NotImplementedException();
        }
    }

    interface IEntity
    {
        int Id { get; }
    }

    class Repostiory<T> where T : IEntity
    {
        protected IEnumerable<T> _elements;

        public Repostiory(IEnumerable<T> elements)
        {
            _elements = elements;
        }

        public T FindById(int Id)
        {
            return _elements.SingleOrDefault(e => e.Id == Id);
        }
    }
}
