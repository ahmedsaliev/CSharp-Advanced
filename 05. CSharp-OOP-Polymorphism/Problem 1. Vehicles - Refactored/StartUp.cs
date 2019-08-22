using System;

namespace VehiclesWorld
{
    public class StartUp
    {
        public static void Main()
        {
            string[] carArgs = Console.ReadLine().Split();
            string[] truckArgs = Console.ReadLine().Split();

            Vehicle car = new Car(double.Parse(carArgs[1]), double.Parse(carArgs[2]));
            Vehicle truck = new Truck(double.Parse(truckArgs[1]), double.Parse(truckArgs[2]));

            int countOfCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < countOfCommands; i++)
            {
                string[] commandArgs = Console.ReadLine().Split();
                string command = commandArgs[0];
                string vehicleType = commandArgs[1];

                if (command == "Drive")
                {
                    double distance = double.Parse(commandArgs[2]);

                    if (vehicleType == "Car")
                    {
                        Console.WriteLine(car.Drive(distance));
                    }
                    else
                    {
                        Console.WriteLine(truck.Drive(distance));
                    }
                }
                else
                {
                    double fuelAmount = double.Parse(commandArgs[2]);

                    if (vehicleType == "Car")
                    {
                        car.Refuel(fuelAmount);
                    }
                    else
                    {
                        truck.Refuel(fuelAmount);
                    }
                }
            }

            Console.WriteLine(car);
            Console.WriteLine(truck);
        }
    }
}
