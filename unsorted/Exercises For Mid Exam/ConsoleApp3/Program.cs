namespace _02._Herlock_s_Code
{
    using System;
    using System.Linq;

    class StartUp
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split().ToArray();

            string command = Console.ReadLine();
            long result = 0;
            long sum = 0;

            while (command != "END")
            {

                string[] com = command.Split().ToArray();
                int index = int.Parse(com[0]);
                string modifier = com[1];

                if (index >= 0 && index < input.Length)
                {
                    string fact = input[index];

                    switch (modifier)
                    {
                        case "Basic":
                            result = GetBasicResult(result, fact);
                            break;

                        case "Weird":
                            result = GetWeirdResult(result, fact);
                            break;
                    }
                    sum += result;
                }

                command = Console.ReadLine();
            }
            Console.WriteLine(sum);

        }

        public static long GetWeirdResult(long result, string fact)
        {
            if (fact[0] == '*')
            {
                result = result * fact.Length;
            }
            else if (fact[0] >= 65 && fact[0] <= 90)
            {
                result = Math.Abs(fact[1] - fact[2]);
            }
            else if (fact[0] >= 48 && fact[0] <= 57)
            {
                result = Math.Abs(fact[1] - fact[2]);
            }
            return result;
        }

        public static long GetBasicResult(long result, string fact)
        {
            if (fact[0] == '*')
            {
                result = result * fact.Length;
            }
            else if (fact[0] >= 65 && fact[0] <= 90)
            {
                result = (fact[0] + fact[1]) * fact[2];
            }
            else if (fact[0] >= 48 && fact[0] <= 57)
            {
                result = (fact[0] + fact[1]) * fact[2];
            }
            return result;
        }
    }
}

