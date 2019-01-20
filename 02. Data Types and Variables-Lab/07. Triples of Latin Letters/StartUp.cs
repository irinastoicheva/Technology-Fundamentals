namespace _07._Triples_of_Latin_Letters
{
    using System;

    class StartUp
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                for (int j = 1; j <= number; j++)
                {
                    for (int k = 1; k <= number; k++)
                    {
                        Console.Write((char)(i + 96));
                        Console.Write((char)(j + 96));
                        Console.WriteLine((char)(k + 96));
                    }
                }
            }
        }
    }
}
