using System;

namespace Garage
{
    public class Zero : Vehicle, IElectricVehicle
    {
        public double BatteryKWh { get; set; }

        public void ChargeBattery()
        {
            BatteryKWh = 100.00;
        }
        public double CurrentChargePercentage()
        {
            return BatteryKWh;            
        }
    }
}