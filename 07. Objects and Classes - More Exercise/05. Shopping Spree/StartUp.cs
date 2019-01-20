namespace _05._Shopping_Spree
{
    using System;
    using System.Collections.Generic;

    public class Person
    {
        public Person(string name, decimal money)
        {
            Name = name;
            Money = money;
        }
        public string Name { get; set; }
        public decimal Money { get; set; }
        public List<string> BagOfProducts { get; set; } = new List<string>();
    }
    public class Product
    {
        public Product(string name, decimal price)
        {
            Name = name;
            Price = price;
        }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
    class StartUp
    {
        public static void Main()
        {
            List<Person> persons = new List<Person>();
            string[] input = Console.ReadLine().Split(new char[] {';'}, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < input.Length; i++)
            {
                string[] inputForPersons = input[i].Split(new char[] {'='}, StringSplitOptions.RemoveEmptyEntries);
                string name = inputForPersons[0];
                decimal money = decimal.Parse(inputForPersons[1]);

                Person currentPerson = new Person(name, money);
                persons.Add(currentPerson);
            }

            List<Product> products = new List<Product>();
            string[] line = Console.ReadLine().Split(new char[] {';'}, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < line.Length; i++)
            {
                string[] inputForProduct = line[i].Split(new char[] {'='}, StringSplitOptions.RemoveEmptyEntries);
                string name = inputForProduct[0];
                decimal price = decimal.Parse(inputForProduct[1]);

                Product currentProduct = new Product(name, price);
                products.Add(currentProduct);
            }

            string command = Console.ReadLine();
            while (command != "END")
            {
                string[] purchas = command.Split();
                string personName = purchas[0];
                string productName = purchas[1];

                foreach (var person in persons)
                {
                    if (person.Name == personName)
                    {
                        foreach (var product in products)
                        {
                            if (product.Name == productName)
                            {
                                if (person.Money >= product.Price)
                                {
                                    person.BagOfProducts.Add(productName);
                                    Console.WriteLine($"{person.Name} bought {product.Name}");
                                    person.Money -= product.Price;
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine($"{person.Name} can't afford {product.Name}");
                                    break;
                                }
                            }
                        }
                    }
                }
                command = Console.ReadLine();
            }
            foreach (var person in persons)
            {
                if (person.BagOfProducts.Count > 0)
                {
                    Console.WriteLine($"{person.Name} - {string.Join(", ", person.BagOfProducts)}");
                }
                else
                {
                    Console.WriteLine($"{person.Name} - Nothing bought");
                }
            }
        }
    }
}
