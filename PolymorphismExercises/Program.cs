using System;

namespace PolymorphismExercises
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] carInfo = Console.ReadLine().Split();
            string[] truckInfo = Console.ReadLine().Split();

            double carFuelQuantity = double.Parse(carInfo[1]);
            double carConsumption = double.Parse(carInfo[2]);

            double truckFuelQuantity = double.Parse(carInfo[1]);
            double truckConsumption = double.Parse(carInfo[2]);

            int n = int.Parse(Console.ReadLine());

            Car car = new Car(carFuelQuantity, carConsumption);
            Truck truck = new Truck(truckFuelQuantity, truckConsumption);

            for (int i = 0; i < n; i++)
            {
                string[] cmd = Console.ReadLine().Split();

                if (cmd[0] == "Drive")
                {
                    double km = double.Parse(cmd[2]);
                    if (cmd[1] == "Car")
                    {
                        
                        if (car.IsEnoughFuel(km))
                        {
                            car.Drive(km);
                            Console.WriteLine($"Car travelled {km} km");

                        }
                        else
                        {
                            Console.WriteLine("Car needs refueling");
                        }
                    }
                    else 
                    {
                        if (truck.IsEnoughFuel(km))
                        {
                            truck.Drive(km);
                            Console.WriteLine($"Truck travelled {km} km");

                        }
                        else
                        {
                            Console.WriteLine("Truck needs refueling");
                        }
                    }
                }
                else 
                {
                    double amount = double.Parse(cmd[2]);
                    if (cmd[1] == "Car")
                    {
                        car.Refueled(amount);
                    }
                    else if (cmd[1] == "Truck")
                    {
                        truck.Refueled(amount);
                    }

                }

            }

            Console.WriteLine($"Car: {car.FuelQuantity:f2}");

            Console.WriteLine($"Truck: {truck.FuelQuantity:f2}");


        }
    }
}
