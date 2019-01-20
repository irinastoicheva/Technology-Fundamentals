namespace _05._Digits__Letters_and_Other
{
    using System;
    using System.Text;

    class StartUp
    {
        public static void Main()
        {
            string text = Console.ReadLine();
            StringBuilder digits = new StringBuilder();
            StringBuilder letters = new StringBuilder();
            StringBuilder symbols = new StringBuilder();

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] >= '0' && text[i] <= '9')
                {
                    digits.Append(text[i]);
                }
                else if (text[i] >= 'a' && text[i] <= 'z' || text[i] >= 'A' && text[i] <= 'Z')
                {
                    letters.Append(text[i]);
                }
                else
                {
                    symbols.Append(text[i]);
                }
            }
            Console.WriteLine(digits.ToString());
            Console.WriteLine(letters.ToString());
            Console.WriteLine(symbols.ToString());
        }
    }
}
