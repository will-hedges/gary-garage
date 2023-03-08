using System;

namespace Garage
{
    public class Tesla : Vehicle
    {
        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Tesla zooms past you. Mmmmmmmmmmmmmmmmmmm!");
        }

        public override void Turn()
        {
            Console.WriteLine($"The {MainColor} Tesla skids around a right corner!");
        }

        public override void Stop()
        {
            Console.WriteLine(
                $"The {MainColor} Tesla's auto-drive detects a small child in the road. It stops quickly, but the driver's coffee goes everywhere!"
            );
        }
    }
}
