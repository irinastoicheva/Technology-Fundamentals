namespace _02._Grades
{
    using System;
    class StartUp
    {
        static void Main()
        {
            double grade = double.Parse(Console.ReadLine());
            PrintGrade(grade);
        }

        public static void PrintGrade(double number)
        {
            if (number >= 2 && number < 3)
            {
                Console.WriteLine("Fail");
            }
            else if (number >= 3 && number <= 3.49)
            {
                Console.WriteLine("Poor");
            }
            else if (number >= 3.5 && number <= 4.49)
            {
                Console.WriteLine("Good");
            }
            else if (number >= 4.5 && number <= 5.49)
            {
                Console.WriteLine("Very good");
            }
            else if (number >= 5.5 && number <= 6)
            {
                Console.WriteLine("Excellent");
            }
        }
    }
}
