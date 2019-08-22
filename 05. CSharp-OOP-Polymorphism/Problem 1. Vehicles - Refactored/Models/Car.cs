using System;
using System.Collections.Generic;
using System.Text;

namespace VehiclesWorld
{
    public class Car : Vehicle
    {
        private double airConditionFactor = 0.9;

        public Car(double fuelQuantity, double fuelConsumption)
            : base(fuelQuantity, fuelConsumption)
        {
            this.FuelConsumption += airConditionFactor;
        }
    }
}