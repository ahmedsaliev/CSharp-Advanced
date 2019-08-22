using System;
using System.Collections.Generic;
using System.Text;

namespace VehiclesWorld
{
    public class Car : Vehicle
    {
        public Car(double fuelQuantity, double fuelConsumption)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption + 0.9;
        }
    }
}