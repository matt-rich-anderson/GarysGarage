using System;

namespace Garage
{
    public class Ram : Vehicle, IGasVehicle
    {
        public double FuelCapacity { get; set; }

        public void RefuelTank()
        {
            FuelCapacity = 100.00;
        }
        public double CurrentTankPercentage()
        {
            return FuelCapacity;            
        }
    }
}