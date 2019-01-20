
namespace _5.Word_in_Plural
{
    using System;
    public class StartUp
    {
        public static void Main()
        {
            string noun = Console.ReadLine();
            char lastLetter = noun[noun.Length - 1];
            string removeLastLetter = noun.Remove(noun.Length - 1, 1);
            if (lastLetter == 'y')
            {
                Console.WriteLine($"{removeLastLetter}ies");
            }
            else if (lastLetter == 'o' || lastLetter == 's' || lastLetter == 'x' || lastLetter == 'z')
            {
                Console.WriteLine($"{noun}es");
            }
            else if (lastLetter == 'h')
            {
                char penultimateLetter = noun[noun.Length - 2];
                if (penultimateLetter == 's' || penultimateLetter == 'c')
                {
                    Console.WriteLine($"{noun}es");
                }
                else
                {
                    Console.WriteLine($"{noun}s");
                }
            }
            else
            {
                Console.WriteLine($"{noun}s");
            }
        }
    }
}
