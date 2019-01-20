namespace _02._Oldest_Family_Member
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Person
    {
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public string Name { get; set; }
        public int Age { get; set; }
    }

    public class Family
    {
        public List<Person> Persons { get; set; }
        public Family()
        {
            Persons = new List<Person>();
        }
        public void AddMember(Person currentPerson)
        {
            Persons.Add(currentPerson);
        }
        public Person GetOldestMember()
        {
            return Persons.OrderByDescending(p => p.Age).First();
        }
    }
    class StartUp
    {
        public static void Main()
        {
            Family Persons = new Family();
            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i < number; i++)
            {
                string[] input = Console.ReadLine().Split();
                string name = input[0];
                int age = int.Parse(input[1]);

                Person currentPerson = new Person(name, age);
                Persons.AddMember(currentPerson);
            }
            var oldPerson = Persons.GetOldestMember();
            Console.WriteLine($"{oldPerson.Name} {oldPerson.Age}");
        }
    }
}
