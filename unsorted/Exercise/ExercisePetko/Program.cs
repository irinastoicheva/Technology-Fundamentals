namespace ExercisePetko
{
    using System;
    using System.Text;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().ToArray();
            HashSet<int> output = new HashSet<int>();

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < input.Length; j++)
                {

                }
                input[]
            }
            for (int i = 0; i < input.Length; i++)
            {
                HashSet<string> temp = new HashSet<string>();

                for (int j = i; j < input.Length; j++)
                {
                    temp.Add(input[j]);

                    foreach (var item in temp)
                    {
                        sb.Append(item);
                    }

                    output.Add(sb.ToString());
                    sb.Clear();
                }
            }





            Console.WriteLine(string.Join(" ", output));
        }
    }
}
