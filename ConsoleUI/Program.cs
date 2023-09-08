using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Todo follow all comments!! 
             */
            Car car = new Car() { HasTrunk = "yes", Year = "2012", Make = "Best car", Model = "nature destroyer" };
            Motorcycle motorcycle = new Motorcycle() { HasSideCart = "yes", Year = "2015", Make = "free bird", Model = "mounten explorer" };
            Vehicle vehicle2 = new Car() { HasTrunk = "no", Year = "2020", Make = "Tesela", Model = "elecric vroom vroom" };
            Vehicle vehicle1 = new Motorcycle() { HasSideCart = "no", Year = "2018", Make = "calateral damage", Model = "idk" };

            Motorcycle betterMotorcycle = new Motorcycle();
            #region Vehicles

            /*
             * Create an abstract class called Vehicle
             * The vehicle class shall have three string properties Year, Make, and Model
             * Set the defaults to something generic in the Vehicle class
             * Vehicle shall have an abstract method called DriveAbstract with no implementation
             * Vehicle shall have a virtual method called DriveVirtual with a base implementation.
             */

            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * Provide the implementations for the abstract methods
             * Only in the Motorcycle class will you override the virtual drive method
            */

            // Create a list of Vehicle called vehicles
            List<Vehicle> vehicles = new List<Vehicle>();
            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * 
             * Set the properties with object initializer syntax
             */

            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties
             */
            vehicles.Add(vehicle2);
            vehicles.Add(vehicle1);
            vehicles.Add(motorcycle);
            vehicles.Add(car);
            foreach (var vehicle in vehicles)
            {
                Console.WriteLine($"This was made in {vehicle.Year}");
                Console.WriteLine($"The make is {vehicle.Make}");
                Console.WriteLine($"The modle is the {vehicle.Make}");
                Console.WriteLine("");
                vehicle.DriveVirtual();
                vehicle.DriveAbstract();
            }
            // Call each of the drive methods for one car and one motorcycle
            //motorcycle.DriveVirtual();
            #endregion
            Console.ReadLine();
        }
    }
}
