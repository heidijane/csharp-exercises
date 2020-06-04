using System;

namespace inheritance
{
    public class Tesla : Vehicle
    {
        public double BatteryKWh { get; set; }

        public void ChargeBattery()
        {
            // method definition omitted
        }

        public override void Drive()
        {
            Console.WriteLine($"The {base.MainColor} Tesla glides by. Zzzzzzzzrrrrrrrrrrr!");
        }
    }
}