namespace DefiningClasses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        static void Main()
        {
            int count = int.Parse(Console.ReadLine());
            List<Employee> employeeList = new List<Employee>();

            for (int i = 0; i < count; i++)
            {
                string[] inputLine = Console.ReadLine().Split();
                string name = inputLine[0];
                double salary = double.Parse(inputLine[1]);
                string position = inputLine[2];
                string department = inputLine[3];

                Employee employee = new Employee(name, salary, position, department);
                string email;
                int age;

                if (inputLine.Length == 4)
                {
                    employeeList.Add(employee);
                }
                else if (inputLine.Length == 5)
                {
                    if (Int32.TryParse(inputLine[4], out age))
                    {
                        employee.Age = age;
                        employeeList.Add(employee);
                    }
                    else
                    {
                        email = inputLine[4];
                        employee.Email = email;
                        employeeList.Add(employee);
                    }
                }
                else
                {
                    email = inputLine[4];
                    age = int.Parse(inputLine[5]);
                    employee.Email = email;
                    employee.Age = age;
                    employeeList.Add(employee);
                }
            }

            Dictionary<string, double> totalSalaries = new Dictionary<string, double>();
            foreach (Employee employee in employeeList)
            {
                if (totalSalaries.ContainsKey(employee.Department))
                {
                    totalSalaries[employee.Department] += employee.Salary;
                }
                else
                {
                    totalSalaries[employee.Department] = employee.Salary;
                }
            }

            double highestAverageSalary = double.MinValue;
            string highestPaidDepartment = "";

            foreach (string department in totalSalaries.Keys)
            {
                double averageSalary = totalSalaries[department] / employeeList.Where(e => e.Department == department).Count();
                if (averageSalary > highestAverageSalary)
                {
                    highestAverageSalary = averageSalary;
                    highestPaidDepartment = department;
                }
            }

            Console.WriteLine("Highest Average Salary: {0}", highestPaidDepartment);
            foreach (Employee employee in employeeList.Where(e => e.Department == highestPaidDepartment).OrderByDescending(e => e.Salary))
            {
                Console.WriteLine("{0} {1:F2} {2} {3}", employee.Name, employee.Salary, employee.Email, employee.Age);
            }
        }
    }
}