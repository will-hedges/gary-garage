using System;

namespace Garage
{
    public class Cessna : Vehicle
    {
        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Cessna flies past you. Zzzzzzzzooooommmmmm!");
        }

        public override void Turn()
        {
            Console.WriteLine($"The {MainColor} Cessna does a right-turn barrel roll! Wow!");
        }

        public override void Stop()
        {
            Console.WriteLine(
                $"The {MainColor} Cessna touches down gracefully and slowly rolls to a stop. The crowd goes wild. The women are feral for the pilot."
            );
        }
    }
}
