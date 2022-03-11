using System;

namespace Garage
{
    public class Vehicle
    {
        public string MainColor { get; set; }
        public int MaximumOccupancy { get; set; }
        public virtual void Drive()
        {
            Console.WriteLine("Vrooom!");
        }
        public virtual void Turn(string direction)
        {
            Console.WriteLine($"Vechicle makes a {direction} turn!");
        }
        public virtual void Stop()
        {
            Console.WriteLine($"Vechicle comes to a stop!");
        }

    }
}