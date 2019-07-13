using System;
using System.Linq;
using System.Collections.Generic;

namespace _06.__Auto_Repair_and_Service
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            Queue<string> vehiclesAll = new Queue<string>(input);

            Stack<string> servedVehicles = new Stack<string>();

            while (true)
            {
                string[] commandLine = Console.ReadLine()
                .Split(new char[] { ' ', '-' }, StringSplitOptions.RemoveEmptyEntries);

                switch (commandLine[0])
                {
                    case "End":
                        if (vehiclesAll.Any())
                        {
                            Console.Write("Vehicles for service: ");
                            Console.WriteLine(String.Join(", ", vehiclesAll.ToArray()));
                        }
                        Console.Write("Served vehicles: ");
                        Console.WriteLine(String.Join(", ", servedVehicles.ToArray()));
                        return;

                    case "Service":
                        if (vehiclesAll.Any())
                        {
                            string car = vehiclesAll.Peek();
                            Console.WriteLine($"Vehicle {car} got served.");
                            servedVehicles.Push(car);
                            vehiclesAll.Dequeue();
                        }
                        break;
                    case "History":
                        Console.WriteLine(String.Join(", ", servedVehicles.ToArray()));
                        break;
                    default:
                        if (vehiclesAll.Contains(commandLine[1]))
                        {
                            Console.WriteLine("Still waiting for service.");
                        }
                        else
                        {
                            Console.WriteLine("Served.");
                        }
                        break;
                }
            }
        }
    }
}