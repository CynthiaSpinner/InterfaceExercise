using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<IVehicle>();

            var cynthiaCar = new Car()
            {
                Country = "Japan",
                Insignia = "Oval",
                Make = "Toyota",
                Model = "Camery",
                Color = "black",
                Year = 2024,
                NumberOfDoors = 4,
                NumberOfSeats = 5,

            };
        
           var truck1 = new Truck()
           {
                Country = "US",
                Insignia = "red lines",
                Make = "Kensworth",
                Model = "T680",
                NumberOfDoors = 2,
                NumberOfSeats = 2,
                EngineSize = "MX-13 12.9 liter",
                NumberOfWheels = 18,

           };
           var suv1 = new SUV()
           {
               Country = "UK",
               Insignia = "Land Rover",
               Make = "Land Rover",
               Model = "Range Rover",
               NumberOfDoors = 4,
               NumberOfSeats = 5,
               FourWheelDrive = true,
               StorageSpace = true
           };

            list.Add(cynthiaCar);
            list.Add(truck1);
            list.Add(suv1);

            
           
            foreach (IVehicle item in list)
            {
                item.DisplayDetails();
            }
           

            
        }
    }
}
