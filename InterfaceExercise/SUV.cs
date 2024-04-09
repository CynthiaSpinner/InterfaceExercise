using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class SUV : IVehicle, ICompany
    {
        public bool FourWheelDrive { get; set; }
        public bool StorageSpace { get; set; }
        public int NumberOfDoors { get; set; }
        public int NumberOfSeats { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Insignia { get; set; }
        public string Country { get; set; }

        public void DisplayDetails()
        {
            Console.WriteLine($"Does my {Make}, {Model} have 4 wheel drive: {FourWheelDrive}");
        }
    }
}
