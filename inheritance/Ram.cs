using System;

namespace inheritance
{
    public class Ram : Vehicle, IGasVehicle
    {
        public double FuelCapacity { get; set; }

        public int CurrentTankPercentage { get; set; }

        void RefuelTank()
        {
            CurrentTankPercentage = 100;
        }

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