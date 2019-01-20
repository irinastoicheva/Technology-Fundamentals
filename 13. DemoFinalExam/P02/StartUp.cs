namespace P02
{
    using System;
    using System.Text;

    class Program
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            bool isNotValid = false;
            for (int i = 0; i < input.Length; i++)
            {
                if (!((input[i] >= 100 && input[i] <= 122) || input[i] =='|' || input[i] == '#' || input[i] == ','))
                {
                    isNotValid = true;
                }
            }

            if (isNotValid)
            {
                Console.WriteLine("This is not the book you are looking for.");
                return;
            }

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {
                sb.Append((char)(input[i] - 3));
            }
            sb.ToString();

            string[] input2 = Console.ReadLine().Split();
            string forReplacement = input2[0];
            string replacement = input2[1];

            string line = sb.ToString();
            sb.Clear();
            string[] newString = line.Split(forReplacement);

            for (int i = 0; i < newString.Length - 1; i++)
            {
                sb.Append(newString[i]);
                sb.Append(replacement);
            }
            sb.Append(newString[newString.Length - 1]);

            Console.WriteLine(sb.ToString());
        }
    }
}
