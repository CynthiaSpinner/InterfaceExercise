using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class Car : IVehicle , ICompany
    {
        public string Color { get; set; } = "black";
        public int Year { get; set; } = 2024;
        public int NumberOfDoors { get; set; } = 4;
        public int NumberOfSeats { get; set; } = 4;
        public string Make { get; set; } = "Generic";   
        public string Model { get; set; } = "Generic";
        public string Insignia { get; set; } = "Generic";
        public string Country { get; set; } = "Generic";

        public void DisplayDetails()
        {
            Console.WriteLine($"My {Year}, {Make} {Model} is made in {Country}");
        }

    }
}
