using System;
using System.Globalization;
using Course.Entities.Enums;
using Course.Entities;


namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter depaartament's name: ");
            string deptName = Console.ReadLine();
            Console.WriteLine("Enter worker data:");
            Console.Write("Name");
            string name = Console.ReadLine();
            Console.Write("Level (Junior/MidLevel/Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Base salary: ");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
        }
    }
}
