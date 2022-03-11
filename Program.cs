using System;

namespace Garage
{
    class Program
    {
        static void Main(string[] args) 
        {
            Zero Hitashi = new Zero();
            Hitashi.MainColor = "Steel Blue"; 

            Console.Write($"The {Hitashi.MainColor} Zero zooms by.");
            Hitashi.Drive();
            Hitashi.Turn("left");
            Hitashi.Stop();

            Vehicle Triumph = new Vehicle();

        }
    }
}
