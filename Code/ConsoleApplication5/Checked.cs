using System;

namespace ConsoleApplication5
{
    public class Checked
    {
        public static void Wrapped(int add)
        {
            try
            {
                checked
                {
                    var test = int.MaxValue + add;
                }
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
