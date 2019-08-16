using System;

namespace Mankind
{
    public class StartUp
    {
        public static void Main()
        {
            try
            {
                string[] studentArgs = Console.ReadLine().Split();
                string studentFirstName = studentArgs[0];
                string studentLastName = studentArgs[1];
                string facultyNumber = studentArgs[2];

                string[] workerArgs = Console.ReadLine().Split();
                string workerFirstName = workerArgs[0];
                string workerLastName = workerArgs[1];
                double weekSalary = double.Parse(workerArgs[2]);
                double hoursPerDay = double.Parse(workerArgs[3]);

                Student student = new Student(studentFirstName, studentLastName, facultyNumber);
                Worker worker = new Worker(workerFirstName, workerLastName, weekSalary, hoursPerDay);

                Console.WriteLine(student + Environment.NewLine);
                Console.WriteLine(worker);
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }
        }
    }
}
