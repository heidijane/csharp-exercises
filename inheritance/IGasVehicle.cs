using System;

namespace inheritance
{
    public interface IGasVehicle
    {
        int CurrentTankPercentage { get; set; }
        void RefuelTank()
        {
            CurrentTankPercentage = 100;
        }
    }
}