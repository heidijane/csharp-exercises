using System;

namespace inheritance
{
    public class Vehicle
    {
        public string MainColor { get; set; }
        public string MaximumOccupancy { get; set; }

        public virtual void Drive() //the "virtual" keyword makes it so the method can be overridden
        {
            Console.WriteLine("Vrooom!");
        }

        public virtual void Turn(string direction)
        {
            Console.WriteLine($"The vehicle turns {direction}.");
        }

        public virtual void Stop()
        {
            Console.WriteLine("The vehicle gently rolls to a stop.");
        }
    }
}