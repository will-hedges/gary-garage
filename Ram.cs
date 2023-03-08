using System;

namespace Garage
{
    public class Ram : Vehicle
    {
        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Ram rolls past you. Rrrrrrrrruuummmmmmm!");
        }

        public override void Turn()
        {
            Console.WriteLine($"The {MainColor} Ram whips a quick right and almost flips over!");
        }

        public override void Stop()
        {
            Console.WriteLine(
                $"The {MainColor} Ram comes to a sudden stop... in a ditch. The driver, still holding his cigarette, swears profusely."
            );
        }
    }
}
