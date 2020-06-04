using System;

namespace inheritance
{
    public interface IElectricVehicle
    {
        int CurrentChargePercentage { get; set; }
        void ChargeBattery()
        {
            CurrentChargePercentage = 100;
        }
    }
}