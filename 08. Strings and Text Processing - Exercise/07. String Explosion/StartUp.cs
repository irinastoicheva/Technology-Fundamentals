namespace _07._String_Explosion
{
    using System;
    using System.Collections.Generic;

    class StartUp
    {
        public static void Main()
        {
            char[] text = Console.ReadLine().ToCharArray();
            int power = 0;
            for (int i = 0; i < text.Length; i++)
            {
                power--;

                if (text[i] == '>')
                {
                    if (i < text.Length - 1)
                    {
                        if (power <= 0)
                        {
                            power = (int)Char.GetNumericValue(text[i + 1]) + 1;
                        }
                        else
                        {
                            power += (int)Char.GetNumericValue(text[i + 1])+ 1;
                        }
                    }
                }
                else if (text[i] != '>' && power > 0)
                {
                    text[i] = (char)0;
                }
            }

            List<char> output = new List<char>();
            foreach (var item in text)
            {
                if (item != (char)0)
                {
                    output.Add(item);
                }
            }
            Console.WriteLine(string.Join("", output));
        }
    }
}
