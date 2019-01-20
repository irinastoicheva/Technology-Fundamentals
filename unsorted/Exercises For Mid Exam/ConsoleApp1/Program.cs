using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            if (fact[0] == '*')
            {
                result = result * fact.Length;
                return result;
            }
            else if (fact[0] >= 65 && fact[0] <= 90)
            {
                result = (fact[0] + fact[1]) * fact[2];
                return result;
            }
            else if (fact[0] >= 48 && fact[0] <= 57)
            {
                result = (fact[0] + fact[1]) * fact[2];
                return result;
            }

        }
    }
}
