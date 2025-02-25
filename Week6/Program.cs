using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6
{
    //Base class Vehicle
    //Other classes based on this one
    public class Vehicle
    {
        // Properties of Vehicle class
        //Gets and sets properties
        public string Make { get; set; }

        public string Model { get; set; }

        public int Year { get; set; }

        public int MaxSpeed { get; set; }


        //Properties
        public Vehicle(string make, string model, int year, int maxSpeed)
        {
            Make = make;
            Model = model;
            Year = year;
            MaxSpeed = maxSpeed;
        }

        //Method to display the cars information
        public void DisplayInfo()
        {
            Console.WriteLine($"Make: {Make}");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Year: {Year}");
            Console.WriteLine($"Max Speed: {MaxSpeed} km/h");
        }
    }

    // Derived class Car, inherits from Vehicle
    public class Car : Vehicle
    {
        // Additional property for Car class
        public int NumberOfDoors { get; set; }

        //Class care values 
        public Car(string make, string model, int year, int maxSpeed, int numberOfDoors)
            : base(make, model, year, maxSpeed)
        {
            NumberOfDoors = numberOfDoors;
        }

        // Override DisplayInfo to include car-specific info
        public new void DisplayInfo()
        {
            base.DisplayInfo();
            //Writes out the number of doors
            Console.WriteLine($"Number of Doors: {NumberOfDoors}");
        }
    }

    // Derived class Motorcycle, inherits from Vehicle
    public class Motorcycle : Vehicle
    {
        // Additional property for Motorcycle class
        public bool HasSidecar { get; set; }

        // Constructor for Motorcycle class
        public Motorcycle(string make, string model, int year, int maxSpeed, bool hasSidecar)
            : base(make, model, year, maxSpeed)
        {
            HasSidecar = hasSidecar;
        }

        // Override DisplayInfo to include motorcycle-specific info
        public new void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Has Sidecar: {HasSidecar}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create instances of Car and Motorcycle
            Car car = new Car("Toyota", "Corolla", 2020, 180, 4);
            Motorcycle motorcycle = new Motorcycle("Harley-Davidson", "Sportster", 2023, 200, true);

            // Display information about each vehicle
            Console.WriteLine("Car Information:");
            car.DisplayInfo();
            Console.WriteLine();

            //Display information about motorcycles 
            Console.WriteLine("Motorcycle Information:");
            motorcycle.DisplayInfo();
        }
    }
}
