namespace _05._Multiply_Big_Number
{
    using System;
    using System.Text;
    using System.Linq;

    class Program
    {
        public static void Main()
        {
            string bigNumber = Console.ReadLine();
            StringBuilder sb = new StringBuilder();
            int number = int.Parse(Console.ReadLine());
            if (number == 0)
            {
                Console.WriteLine(0);
                return;
            }
            else
            {
                int mind = 0;
                for (int i = bigNumber.Length - 1; i >= 0; i--)
                {
                    int num = int.Parse(bigNumber[i].ToString()) * number + mind;
                    mind = num / 10;
                    sb.Append(num % 10);
                }
                if (mind > 0)
                {
                    sb.Append(mind);
                }
            }
            
            char[] array = sb.ToString().ToCharArray().Reverse().ToArray();
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] == '0')
                {
                    array[i] = 'x';
                }
                else
                {
                    break;
                }
            }
            foreach (var item in array)
            {
                if (item != 'x')
                {
                    Console.Write(item);
                }
            }
            Console.WriteLine();
        }
    }
}
