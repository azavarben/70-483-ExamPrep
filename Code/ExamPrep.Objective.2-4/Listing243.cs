using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPrep.Objective._2_4
{
    class Listing243
    {
        internal static void InterfaceWithGenericTypeParameter()
        {
            throw new NotImplementedException();
        }
    }

    interface IRepository<T>
    {
        T FindById(int id);
        IEnumerable<T> All();
    }

    public class Product
    {
        public string Name { get; set; }
        public int Id { get; set; }
    }

    public class ProductRepository : IRepository<Product>
    {
        public IEnumerable<Product> All()
        {
            return new List<Product>();
        }

        public Product FindById(int id)
        {
            return new Product();
        }
    }
}
