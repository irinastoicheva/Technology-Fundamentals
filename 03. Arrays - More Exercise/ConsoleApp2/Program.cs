using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int sizeOfField = int.Parse(Console.ReadLine()); //размера на field-a

        int[] field = new int[sizeOfField];//нов field, на който ще разпределим къде има калинки, като на всяка позиция където има калинка ще отбелязваме по някакъв начин

        int[] initialIndexesOfAllLadybugs = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();//четеме на кои позиции има калинка и ги слагаме в един масив [масив с индексите във филда на които има калинка]

        foreach (var index in initialIndexesOfAllLadybugs)//тук поставяме на кои индекси има калинка във филда с калинките, на всяка позиция където има калинка слагаме "1"
        {
            if (index >= 0 && index <= sizeOfField - 1)//проверяваме дали е валидна позиция преди да сложим калинка
            {
                field[index] = 1;
            }

        }

        while (true)
        {
            string input = Console.ReadLine();

            if (input == "end")
            {
                break;// ако получим команда end приключваме цикъла
            }
            else
            {
                string[] command = input.Split().ToArray();// разглеждаме всяка команда като масив от стрингове, тъй като има и цифри и думи [(цифра)_(дума)_(цифра)]


                int[] commandIntegers = new int[2];//правиме нов масив от два елемента, който ще подслони двете цифри от командата, тоест първия и последния елемент от командата

                commandIntegers[0] = int.Parse(command[0]);
                commandIntegers[1] = int.Parse(command[2]);

                if (commandIntegers[0] >= 0 && commandIntegers[0] < sizeOfField)//проверяваме дали първата позиция от командата където трябва да има калинка изобщо е валидна
                {
                    if (field[commandIntegers[0]] == 1)//проверяваме дали на тази позиция от командата във филда има калинка
                    {
                        field[commandIntegers[0]] = 0; //махаме калинката от началната и позиция
                        if (command[1] == "right")//проверяваме дали калинката ще се движи НАДЯСНО
                        {
                            int indexAfterMovement = commandIntegers[0] + commandIntegers[1];//позицията на която калинката ще застане след преместването

                            if (indexAfterMovement >= 0 && indexAfterMovement < field.Length) //проверяваме дали тази позиция е във field-a
                            {
                                if (field[indexAfterMovement] == 0)//проверяваме дали позицията на която иска да кацне калинката е празна
                                {
                                    field[indexAfterMovement] = 1; //запълваме позицията с калинка
                                }
                                else//ако позицията, на която иска да кацне калинката не е празна, тя не може да кацне върху друга калинка а трябва да продължи напред
                                {
                                    for (int i = indexAfterMovement; i < field.Length; i += commandIntegers[1])
                                    {
                                        if (field[i] == 0)
                                        {
                                            field[i] = 1;
                                            break;
                                        }
                                    }
                                }
                            }
                        }
                        else if (command[1] == "left")//проверяваме дали калинката ще се движи НАЛЯВО
                        {
                            int indexAfterMovement = commandIntegers[0] - commandIntegers[1];//позицията на която калинката ще застане след преместването

                            if (indexAfterMovement >= 0 && indexAfterMovement < field.Length) //проверяваме дали тази позиция е във field-a
                            {
                                if (field[indexAfterMovement] == 0)//проверяваме дали позицията на която иска да кацне калинката е празна
                                {
                                    field[indexAfterMovement] = 1; //запълваме позицията с калинка
                                }
                                else//ако позицията, на която иска да кацне калинката не е празна, тя не може да кацне върху друга калинка а трябва да продължи напред
                                {
                                    for (int i = indexAfterMovement; i < field.Length; i -= commandIntegers[1])
                                    {
                                        if (field[i] == 0)
                                        {
                                            field[i] = 1;
                                            break;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        Console.WriteLine(string.Join(" ", field));
    }
}
