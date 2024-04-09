using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal interface IVehicle
    {
        public int NumberOfDoors { get; set; }
        public int NumberOfSeats { get; set; }
        public string Make {  get; set; }
        public string Model { get; set; }

        public void DisplayDetails();

    }

}
