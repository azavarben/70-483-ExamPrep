using System;

namespace ExampPrep.Threads.UI.ConsoleApp
{
    internal class Listing182
    {
        public static void EventDemo()
        {
            var car = new Car();

            car.OnChange += () => { Console.WriteLine("Event fired, car is >= 60 mph."); };

            car.Speed = 70;

            Console.ReadLine();
        }

        private static void Car_OnChange()
        {
            throw new NotImplementedException();
        }

        public class Car
        {
            private double _speed;

            public event Action OnChange;

            //vs
            //public event DoShit OnChange;
            //public delegate void DoShit();

            public double Speed
            {
                get { return _speed; }
                set
                {
                    _speed = value;

                    if (_speed >= 60)
                    {
                        if (OnChange != null)
                        {
                            OnChange();
                        }
                    }
                }
            }
        }
    }
}