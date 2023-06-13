using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class Motorcycle : IVehicle
    {
        public Motorcycle()
        {

        }

        public void Drive()
        {
            ConsoleLogger.VehicleStartUpDialogue();
            Console.WriteLine($"The motorcycle is revving up!");
            Console.WriteLine($"Vrooooom, vrooooooom");
        }
    }
}
