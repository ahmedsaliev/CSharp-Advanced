using System;
using System.Collections.Generic;
using System.Text;

namespace Mankind
{
    public class Worker : Human
    {
        private double weekSalary;
        private double hoursPerDay;

        public Worker(string firstName, string lastName, double weekSalary, double hoursPerDay)
            : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.HoursPerDay = hoursPerDay;
        }

        public double CalculateSalaryPerHour()
        {
            return this.WeekSalary / (5 * this.HoursPerDay);
        }

        public double WeekSalary
        {
            get => this.weekSalary;
            set
            {
                if (value <= 10)
                {
                    throw new ArgumentException("Expected value mismatch! Argument: weekSalary");
                }
                this.weekSalary = value;
            }
        }

        public double HoursPerDay
        {
            get => this.hoursPerDay;
            set
            {
                if (value < 1 || value > 12)
                {
                    throw new ArgumentException("Expected value mismatch! Argument: workHoursPerDay");
                }
                this.hoursPerDay = value;
            }
        }

        public override string ToString()
        {
            return base.ToString() + Environment.NewLine
                + $"Week Salary: {this.WeekSalary:f2}" + Environment.NewLine
                + $"Hours per day: { this.HoursPerDay:f2}" + Environment.NewLine
                + $"Salary per hour: {CalculateSalaryPerHour():f2}";
        }
    }
}
