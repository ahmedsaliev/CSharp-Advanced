﻿using System;
using System.Text;

public class Car
{
    private string make;
    private string model;
    private int year;
    private double fuelQuantity;
    private double fuelConsumption;

    public string Make
    {
        get { return this.make; }
        set { this.make = value; }
    }

    public string Model
    {
        get { return this.model; }
        set { this.model = value; }
    }

    public int Year
    {
        get { return this.year; }
        set { this.year = value; }
    }

    public double FuelQuantity
    {
        get { return this.fuelQuantity; }
        set { this.fuelQuantity = value; }
    }

    public double FuelConsumption
    {
        get { return this.fuelConsumption; }
        set { this.fuelConsumption = value; }
    }

    public string WhoAmI()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"Make: {this.Make}");
        sb.AppendLine($"Model: {this.Model}");
        sb.AppendLine($"Year: {this.Year}");
        sb.Append($"Fuel: {this.FuelQuantity:F2}L");
        return sb.ToString();
    }
    
    public void Drive(double distance)
    {
        bool canContinue = this.FuelQuantity - (distance * this.FuelConsumption) >= 0;
        if (canContinue)
            this.FuelQuantity -= distance * this.FuelConsumption;
        else
            Console.WriteLine("Not enough fuel to perform this trip!");
    }
}