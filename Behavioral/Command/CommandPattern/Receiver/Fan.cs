using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Receiver
{
    internal class Fan
    {
        public void TurnOn()
        {
            Console.WriteLine("Fan is ON");
        }
        public void TurnOff()
        {
            Console.WriteLine("Fan is OFF");
        }
        public void IncreaseSpeed()
        {
            Console.WriteLine("Speed Increased");
        }
        public void DecreaseSpeed()
        {
            Console.WriteLine("Speed Decreased");
        }
    }
}
