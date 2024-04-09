using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class Truck :IVehicle, ICompany
    {
        public int NumberOfWheels { get; set; }
        public string EngineSize { get; set; }
        public int NumberOfDoors { get; set; }
        public int NumberOfSeats { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Insignia { get; set; }
        public string Country { get; set; }

        public void DisplayDetails()
        {
            Console.WriteLine($"The EngineSize is {EngineSize} on a {Make} {Model}");
        }
    }
}
