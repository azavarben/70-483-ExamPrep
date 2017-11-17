using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPrep.Objective._2_1
{
    class Listing216
    {
        internal static void ExtensionMethodDemo()
        {
            var product = new Product
            {
                Price = 10
            };

            var calc = new Calculator();

            var discount = calc.CalculateDiscount(product);

            Console.WriteLine(discount);
        }
    }

    public class Product
    {
        public decimal Price { get; set; }
    }

    public static class ProductExtensions
    {
        public static decimal Discount(this Product product)
        {
            return product.Price * .9m;
        }
    }

    public class Calculator
    {
        public decimal CalculateDiscount(Product p)
        {
            return p.Discount();
        }
    }
}
