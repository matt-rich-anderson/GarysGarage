using System;

namespace Garage
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
            Console.WriteLine("Errrrrrrerrrr!");
        }
        public override void Turn(string direction)
        {
            Console.WriteLine($"Zero banks to the {direction}!");
        }
        public override void Stop()
        {
            Console.WriteLine("The Zero can't stop!!");
        }
    }
}