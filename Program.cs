using System;

namespace Garage
{
    class Program
    {
        static void Main(string[] args)
        {
            Cessna cessna = new Cessna();
            cessna.MainColor = "white";

            Ram ram = new Ram();
            ram.MainColor = "black";

            Tesla tesla = new Tesla();
            tesla.MainColor = "red";

            Zero zero = new Zero();
            zero.MainColor = "green";

            cessna.Drive();
            cessna.Turn();
            cessna.Stop();

            Console.WriteLine();

            ram.Drive();
            ram.Turn();
            ram.Stop();

            Console.WriteLine();

            tesla.Drive();
            tesla.Turn();
            tesla.Stop();

            Console.WriteLine();

            zero.Drive();
            zero.Turn();
            zero.Stop();
        }
    }
}
