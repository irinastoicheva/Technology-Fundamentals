namespace _05._Multiply_Big_Number
{
    using System;
    using System.Text;

    class StartUp
    {
        public static void Main()
        {
            string firstNumber = Console.ReadLine().TrimStart(new char[] { '0' });
            int secondNumber = int.Parse(Console.ReadLine());
            if (firstNumber == "0" || secondNumber == 0)
            {
                Console.WriteLine(0);
                return;
            }
            bool isNegative = false;
            if (secondNumber < 0)
            {
                isNegative = true;
                secondNumber = Math.Abs(secondNumber);
            }

            StringBuilder sb = new StringBuilder();
            StringBuilder str = new StringBuilder();
            int save = 0;

            for (int i = firstNumber.Length - 1; i >= 0; i--)
            {
                sb.Append(firstNumber[i]);
                int number = int.Parse(sb.ToString()) * secondNumber + save;
                sb.Clear();
                save = number / 10;
                number %= 10;
                str.Insert(0, number);
            }
            if (save != 0)
            {
                str.Insert(0, save);
            }
            if (isNegative)
            {
                str.Insert(0, "-");
            }
            Console.WriteLine(str);
        }
    }
}
