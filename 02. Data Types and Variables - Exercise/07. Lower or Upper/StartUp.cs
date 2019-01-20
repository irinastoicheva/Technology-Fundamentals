namespace _07._Lower_or_Upper
{
    using System;
    class StartUp
    {
        static void Main()
        {
            char input = char.Parse(Console.ReadLine());
            if (input >= 65 && input <= 90)
            {
                Console.WriteLine("upper-case");
            }
            else
            {
                Console.WriteLine("lower-case");
            }
        }
    }
}
