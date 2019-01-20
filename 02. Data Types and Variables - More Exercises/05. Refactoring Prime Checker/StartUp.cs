namespace _05._Refactoring_Prime_Checker
{
    using System;
    class StartUp
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());
            for (int i = 2; i <= input; i++)
{
                bool primeNumber = true;
                for (int j = 2; j < i; j++)
{
                    if (i % j == 0)
                    {
                        primeNumber = false;
                        break;
                    }
                }
                Console.WriteLine($"{i} -> {primeNumber.ToString().ToLower()}");
            }
        }
    }
}
