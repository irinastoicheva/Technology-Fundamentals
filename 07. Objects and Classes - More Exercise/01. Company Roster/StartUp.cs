namespace _01._Company_Roster
{
    using System.Collections.Generic;
    using System;
    using System.Linq;

    public class Employee
    {
        public Employee(string name, double salary, string department)
        {
            Name = name;
            Salary = salary;
            Department = department;
        }
        public string Name { get; set; }
        public double Salary { get; set; }
        public string Department { get; set; }
    }
    class StartUp
    {
        public static void Main()
        {
            List<Employee> list = new List<Employee>();
            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i < number; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string name = input[0];
                double salary = double.Parse(input[1]);
                string department = input[2];

                Employee currentEmployee = new Employee(name, salary, department);
                list.Add(currentEmployee);
            }

            var groups = list.GroupBy(x => x.Department).OrderByDescending(y => y.Average(x => x.Salary)).Take(1);
            foreach (var item in groups)
            {
                Console.WriteLine($"Highest Average Salary: {item.Key}");
                foreach (var employee in item.OrderByDescending(x => x.Salary))
                {
                    Console.WriteLine($"{employee.Name} {employee.Salary:f2}");
                }
            }
        }
    }
}
