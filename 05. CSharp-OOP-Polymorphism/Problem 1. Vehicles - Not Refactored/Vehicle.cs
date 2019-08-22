using System;
using System.Collections.Generic;
using System.Text;

namespace VehiclesWorld
{
    public class Vehicle
    {
        private double fuelQuantity;
        private double fuelConsumption;
 
        public double FuelQuantity
        {
            get => this.fuelQuantity;
            set
            {
                this.fuelQuantity = value;
            }
        }

        public double FuelConsumption
        {
            get => this.fuelConsumption;
            set
            {
                this.fuelConsumption = value;
            }
        }

        public void Drive(double distance)
        {
            if (distance * this.fuelConsumption > this.fuelQuantity)
            {
                Console.WriteLine($"{this.GetType().Name} needs refueling");
            }
            else
            {
                this.fuelQuantity -= distance * this.fuelConsumption;
                Console.WriteLine($"{this.GetType().Name} travelled {distance} km");
            }
        }

        public void Refuel(double fuel)
        {
            this.fuelQuantity += fuel;
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}: {this.fuelQuantity:f2}";
        }
    }
}