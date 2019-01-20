﻿namespace _04._Morse_Code_Translator
{
    using System;
    using System.Text;

    class StartUp
    {
        public static void Main()
        {
            StringBuilder word = new StringBuilder();

            string[] input = Console.ReadLine().Split('|');

            for (int i = 0; i < input.Length; i++)
            {
                string[] letter = input[i].Split();

                for (int j = 0; j < letter.Length; j++)
                {
                    switch (letter[j])
                    {
                        case ".-": word.Append('A'); break;
                        case "-...": word.Append('B'); break;
                        case "-.-.": word.Append('C'); break;
                        case "-..": word.Append('D'); break;
                        case ".": word.Append('E'); break;
                        case "..-.": word.Append('F'); break;
                        case "--.": word.Append('G'); break;
                        case "....": word.Append('H'); break;
                        case "..": word.Append('I'); break;
                        case ".---": word.Append('J'); break;
                        case "-.-": word.Append('K'); break;
                        case ".-..": word.Append('L'); break;
                        case "--": word.Append('M'); break;
                        case "-.": word.Append('N'); break;
                        case "---": word.Append('O'); break;
                        case ".--.": word.Append('P'); break;
                        case "--.-": word.Append('Q'); break;
                        case ".-.": word.Append('R'); break;
                        case "...": word.Append('S'); break;
                        case "-": word.Append('T'); break;
                        case "..-": word.Append('U'); break;
                        case "...-": word.Append('V'); break;
                        case ".--": word.Append('W'); break;
                        case "-..-": word.Append('X'); break;
                        case "-.--": word.Append('Y'); break;
                        case "--..": word.Append('Z'); break;
                    }
                }

                if (i < input.Length - 1)
                {
                    word.Append(" ");
                }

                Console.Write(word);
                word.Clear();
            }

            Console.WriteLine();
        }
    }
}
