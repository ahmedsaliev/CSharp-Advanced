using System;

namespace VehiclesWorld
{
    public class StartUp
    {
        public static void Main()
        {
            string[] firstLine = Console.ReadLine().Split();
            string[] secondLine = Console.ReadLine().Split();

            Vehicle car = new Car(double.Parse(firstLine[1]), double.Parse(firstLine[2]));
            Vehicle truck = new Truck(double.Parse(secondLine[1]), double.Parse(secondLine[2]));

            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string[] commandLine = Console.ReadLine().Split();
                string command = commandLine[0];
                string vehicleType = commandLine[1];
                double quantity = double.Parse(commandLine[2]);

                if (command == "Drive")
                {
                    if (vehicleType == "Car")
                    {
                        car.Drive(quantity);
                    }
                    else
                    {
                        truck.Drive(quantity);
                    }
                }
                else
                {
                    if (vehicleType == "Car")
                    {
                        car.Refuel(quantity);
                    }
                    else
                    {
                        truck.Refuel(quantity * 0.95);
                    }
                }
            }

            Console.WriteLine(car);
            Console.WriteLine(truck);
        }
    }
}
