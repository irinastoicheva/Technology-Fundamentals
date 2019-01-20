namespace _08._Concat_Names
{
    using System;
    class StartUp
    {
        static void Main()
        {
            string firstName = Console.ReadLine();
            string secondName = Console.ReadLine();
            string delimiter = Console.ReadLine();
            Console.WriteLine($"{firstName}{delimiter}{secondName}");
        }
    }
}
