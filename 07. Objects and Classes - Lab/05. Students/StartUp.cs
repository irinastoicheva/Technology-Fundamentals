namespace _05._Students
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string HomeTown { get; set; }
    }
    class StartUp
    {
        public static void Main()
        {
            string command = Console.ReadLine();
            List<Student> students = new List<Student>();
            while (command != "end")
            {
                string[] input = command.Split().ToArray();
                string firstName = input[0];
                string lastName = input[1];
                int age = int.Parse(input[2]);
                string town = input[3];

                Student currentStudent = new Student
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Age = age,
                    HomeTown = town
                };
                students.Add(currentStudent);
                command = Console.ReadLine();
            }
            string printTown = Console.ReadLine();
            students = students.Where(x => x.HomeTown == printTown).ToList();
            foreach (var item in students)
            {
                Console.WriteLine($"{item.FirstName} {item.LastName} is {item.Age} years old.");
            }
        }
    }
}
