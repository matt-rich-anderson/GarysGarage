using System;

namespace Garage
{
    public class Tesla : Vehicle, IElectricVehicle
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