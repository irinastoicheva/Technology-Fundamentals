namespace _04._Floating_Equality
{
    using System;
    class StartUp
    {
        static void Main()
        {
            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());

            if (Math.Abs(firstNumber - secondNumber) > 0.000001)
            {
                Console.WriteLine("False");
            }
            else
            {
                Console.WriteLine("True");
            }
        }
    }
}
