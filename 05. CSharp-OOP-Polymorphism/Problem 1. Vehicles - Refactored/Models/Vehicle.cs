using System;
using System.Collections.Generic;
using System.Text;

namespace VehiclesWorld
{
    public abstract class Vehicle
    {

        public double FuelQuantity { get; protected set; }

        public double FuelConsumption { get; protected set; }

        public Vehicle(double fuelQuantity, double fuelConsumption)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
        }

        public string Drive(double distance)
        {
            if (distance * this.FuelConsumption > this.FuelQuantity)
            {
                return $"{this.GetType().Name} needs refueling";
            }
            else
            {
                this.FuelQuantity -= distance * this.FuelConsumption;
                return $"{this.GetType().Name} travelled {distance} km";
            }
        }

        public virtual void Refuel(double fuel)
        {
            this.FuelQuantity += fuel;
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}: {this.FuelQuantity:F2}";
        }
    }
}