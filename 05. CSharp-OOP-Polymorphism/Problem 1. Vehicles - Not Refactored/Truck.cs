using System;
using System.Collections.Generic;
using System.Text;

namespace VehiclesWorld
{
    public class Truck : Vehicle
    {
        public Truck(double fuelQuantity, double fuelConsumption)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption + 1.6;
        }
    }
}