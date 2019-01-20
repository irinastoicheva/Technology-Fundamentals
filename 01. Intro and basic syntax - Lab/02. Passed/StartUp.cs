namespace _02._Passed
{
    using System;

    class StartUp
    {
        public static void Main()
        {
            double grade = double.Parse(Console.ReadLine());
            if (grade>= 3)
            {
                Console.WriteLine("Passed!");
            }
        }
    }
}
