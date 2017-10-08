using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5.Encryption
{
    public class Hashing
    {
        public static void HashStuff()
        {
            var mypassword = "somesuperstrongpassword";

            var byteArray = Encoding.Unicode.GetBytes(mypassword);

            var passwordHash = SHA256.Create().ComputeHash(byteArray);

            

            var match = passwordHash.SequenceEqual(passwordHash);

            Console.WriteLine($"Do they match? {match}");
            Console.ReadLine();
        }
    }
}
