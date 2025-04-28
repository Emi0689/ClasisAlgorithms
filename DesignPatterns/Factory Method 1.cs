using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    public interface IVehicle
    {
        void Drive();
    }

    public class Car : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Draving a car 🚗");
        }
    }

    public class Bike : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Draving a bike 🚲");
        }
    }

    public static class VehicleFactory
    {
        public static IVehicle CreateVehicle(string type)
        {
            if (type == "Car")
                return new Car();
            else if (type == "Bike")
                return new Bike();
            else
                throw new ArgumentException("Type of vehicle unknown.");
        }
    }

    class ProgramFactory1
    {
        static void Main(string[] args)
        {
            IVehicle myVehicle = VehicleFactory.CreateVehicle("Car");
            myVehicle.Drive();

            IVehicle mySecondVehicle = VehicleFactory.CreateVehicle("Bike");
            mySecondVehicle.Drive();
        }
    }
}
