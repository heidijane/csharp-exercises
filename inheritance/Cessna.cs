using System;

namespace inheritance
{
    public class Cessna : Vehicle, IGasVehicle
    {
        public double FuelCapacity { get; set; }

        public int CurrentTankPercentage { get; set; }
        public void RefuelTank()
        {
            CurrentTankPercentage = 100;
        }

        public override void Drive()
        {
            Console.WriteLine($"The {base.MainColor} Cessna flies past! Zoooooooom!");
        }
        public override void Turn(string direction)
        {
            Console.WriteLine($"The plane leans sideways as it turns {direction}.");
        }

        public override void Stop()
        {
            Console.WriteLine("The Cessna touches down on the runway and comes to a stop after 900 feet.");
        }
    }
}