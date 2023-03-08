using System;

namespace Garage
{
    public class Zero : Vehicle
    {
        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Zero zips past you. Yeeeeeeeeeowwwwwwww!");
        }

        public override void Turn()
        {
            Console.WriteLine($"The {MainColor} Zero leans into a hard right turn, with style!");
        }

        public override void Stop()
        {
            Console.WriteLine(
                $"The {MainColor} Zero lays down and slides for another mile before hitting a guardrail and stopping. The driver is wearing leathers, but is lucky to be alive!"
            );
        }
    }
}
