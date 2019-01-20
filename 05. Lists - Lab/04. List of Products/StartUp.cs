namespace _04._List_of_Products
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            List<string> list = new List <string>();

            for (int i = 0; i < number; i++)
            {
                list.Add(Console.ReadLine());
            }
            list.Sort();
            for (int i = 1; i <= list.Count; i++)
            {
                Console.WriteLine($"{i}.{list[i-1]}");
            }
        }
    }
}
