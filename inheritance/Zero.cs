using System;

namespace inheritance
{
    public class Zero : Vehicle
    {
        public double BatteryKWh { get; set; }

        public void ChargeBattery()
        {
            // method definition omitted
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