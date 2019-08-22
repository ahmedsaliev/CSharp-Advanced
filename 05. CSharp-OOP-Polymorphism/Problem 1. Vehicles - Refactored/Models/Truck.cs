using System;
using System.Collections.Generic;
using System.Text;

namespace VehiclesWorld
{
    public class Truck : Vehicle
    {
        private double looseFuelFactor = 0.95;
        private double airConditionFactor = 1.6;

        public Truck(double fuelQuantity, double fuelConsumption)
            : base(fuelQuantity, fuelConsumption)
        {
            this.FuelConsumption += airConditionFactor;
        }

        public override void Refuel(double fuel)
        {
            this.FuelQuantity += fuel * looseFuelFactor;
        }
    }
}