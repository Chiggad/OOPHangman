using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceÖvning
{
    internal class Tractor : IVehicle
    {
        public int Speed { get; set; }

        public void Stop()
        {
            Speed = 0;
            Console.WriteLine("Stoping....");
            Thread.Sleep(4000);
            Console.WriteLine("Stoped");
        }

        public void AccelerateSlowly(int speed)
        {
            if (speed <= 30)
            {
                Console.WriteLine("Acclerating...");
                Speed = speed;
                Thread.Sleep(10000);
            }
        }

        public override string ToString()
        {
            return "Im a tractor";
        }
    }
}