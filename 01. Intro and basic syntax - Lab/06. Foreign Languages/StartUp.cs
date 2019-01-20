namespace _06._Foreign_Languages
{
    using System;

    class Program
    {
        public static void Main()
        {
            string country = Console.ReadLine();
            if (country=="USA" || country == "England")
            {
                Console.WriteLine("English");
            }
            else if (country == "Mexico" || country == "Argentina" || country == "Spain")
            {
                Console.WriteLine("Spanish");
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}
