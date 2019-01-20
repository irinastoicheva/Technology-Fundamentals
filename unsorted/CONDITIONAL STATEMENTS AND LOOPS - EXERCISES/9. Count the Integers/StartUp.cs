
namespace _9.Count_the_Integers
{
    using System;
    public class StartUp
    {
        public static void Main()
        {
            int counter = 0;
            try
            {
                while (true)
                {
                    int input = int.Parse(Console.ReadLine());

                    counter++;
                }
            }
            catch (Exception)
            {
                Console.WriteLine(counter);
            }
        }
    }
}
