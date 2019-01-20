
namespace _10.Triangle_of_Numbers
{
    using System;
    class StartUp
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            if (n >=1 && n <=20)
            {
                for (int i = 1; i <= n; i++)
                {
                    for (int J = 1; J <= i; J++)
                    {
                        Console.Write(i + " ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
