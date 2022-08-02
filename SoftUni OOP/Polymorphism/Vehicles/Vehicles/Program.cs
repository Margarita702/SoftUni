using System;

namespace Vehicles
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] carInfo = Console.ReadLine().Split();
            string[] truckInfo = Console.ReadLine().Split();
            double carFuelQty = double.Parse(carInfo[1]);
            double carlPerkm = double.Parse(carInfo[2]);
            double truckFuelQty = double.Parse(truckInfo[1]);
            double trucklPerkm=double.Parse(truckInfo[2]);
            Car car = new Car(double.Parse(carInfo[1]), double.Parse(carInfo[2]));
            Truck truck = new Truck(double.Parse(truckInfo[1]), double.Parse(truckInfo[2]));

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] commands = Console.ReadLine().Split();
                string action = commands[0];
                string typeOfVehicle = commands[1];
                double value = double.Parse(commands[2]);

                if (action=="Drive")
                {
                    if (typeOfVehicle =="Car")
                    {
                        if (car.CanDrive(value))
                        {
                            car.Drive(value);
                            Console.WriteLine($"Car travelled {value} km");
                        }
                        else
                        {
                            Console.WriteLine("Car needs refueling");
                        }
                    }
                    else
                    {
                        if (truck.CanDrive(value))
                        {
                            truck.Drive(value);
                            Console.WriteLine($"Truck travelled {value} km");
                        }
                        else
                        {
                            Console.WriteLine("Truck needs refueling");
                        }
                    }
                }
                else
                {
                    if (typeOfVehicle=="Car")
                    {
                        car.Refuel(value);
                    }
                    else
                    {
                        truck.Refuel(value);

                    }
                }
            }
            Console.WriteLine($"Car: {car.FuelQuantity:F2}");
            Console.WriteLine($"Truck: {truck.FuelQuantity:F2}");

        }
    }
}
