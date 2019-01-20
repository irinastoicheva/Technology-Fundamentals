
namespace _11._5_Different_Numbers
{
    using System;
    public class StartUp
    {
        public static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            if (a + 5 <= b)
            {
                for (int n1 = a; n1 <= b - 4; n1++)
                {
                    for (int n2 = n1 + 1; n2 <= b - 3; n2++)
                    {
                        for (int n3 = n2 + 1; n3 <= b - 2; n3++)
                        {
                            for (int n4 = n3 + 1; n4 <= b - 1; n4++)
                            {
                                for (int n5 = n4 + 1; n5 <= b; n5++)
                                {
                                    Console.WriteLine($"{n1} {n2} {n3} {n4} {n5}");
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("No");
            } 
        }
    }
}
