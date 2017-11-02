namespace ExampPrep.Threads.UI.ConsoleApp
{
    internal class Listing180
    {
        public delegate int DoSomethingAwesome(int x, int y);

        public static void MultilineLambda()
        {
            DoSomethingAwesome test = (x, y) =>
            {
                int j = 42;

                return x + y;

            };
        }
    }
}