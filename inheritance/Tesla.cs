using System;

namespace inheritance
{
    public class Tesla : Vehicle, IElectricVehicle
    {
        public double BatteryKWh { get; set; }

        public int CurrentChargePercentage { get; set; }

        public void ChargeBattery()
        {
            CurrentChargePercentage = 100;
        }

        public override void Drive()
        {
            Console.WriteLine($"The {base.MainColor} Tesla glides by. Zzzzzzzzrrrrrrrrrrr!");
        }
    }
}