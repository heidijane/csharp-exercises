using System;

namespace inheritance
{
    public class Ram : Vehicle
    {
        public double FuelCapacity { get; set; }

        public override void Drive()
        {
            Console.WriteLine($"The {base.MainColor} Ram rumbles by. Rrrrrrrrrrrrrr!");
        }

        public override void Turn(string direction)
        {
            Console.WriteLine($"The Ram makes a wide turn {direction}.");
        }
    }
}