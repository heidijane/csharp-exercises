using System;

namespace inheritance
{
    public class Zero : Vehicle, IElectricVehicle
    {
        public double BatteryKWh { get; set; }

        public int CurrentChargePercentage { get; set; }

        public void ChargeBattery()
        {
            CurrentChargePercentage = 100;
        }

        public override void Drive()
        {
            Console.WriteLine($"The {base.MainColor} Zero zips by you! Yeeeeeeeoooow!");
        }

        public override void Stop()
        {
            Console.WriteLine($"The Zero screetches to a halt!");
        }
    }
}