using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPrep.Objective._2_2
{
    class Listing224
    {
        internal static void UserDefinedConversionsDemo()
        {
            Money m = new Money(5.5m);
            decimal d = m; //implicit conversion
            int x = (int)m; //explicit conversion

            Console.WriteLine("d: {0}", d);
            Console.WriteLine("x: {0}", x);
        }
    }

    public class Money 
    {
        public decimal Amount { get; set; }

        public Money(decimal amount)
        {
            Amount = amount;
        }

        public static implicit operator decimal(Money money) //convert the money object in to a decimal
        {
            return money.Amount;
        }

        //explicit is basically saying you're going to loose some precision here, 
        //so we'll have the compliler warn you.
        //could just as easily make it implicit and screw someone over
        public static explicit operator int(Money money)
        {
            return (int)money.Amount;
        }

    }
}
