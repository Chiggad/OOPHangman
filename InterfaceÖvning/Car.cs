using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceÖvning
{
    internal class Car : IVehicle
    {
        public int Speed { get; set; }

        public void Stop()
        {
            Speed = 0;
            Console.WriteLine("Stoping...");
            Thread.Sleep(2000);
            Console.WriteLine("Stoped");
        }

        public void Accelerate(int speed)
        {
            if (speed < 200)
            {
                Console.WriteLine("Acclerating...");
                Speed = speed;
                Thread.Sleep(5000);
            }
        }

        public override string ToString()
        {
            return "Im a car";
        }
    }
}