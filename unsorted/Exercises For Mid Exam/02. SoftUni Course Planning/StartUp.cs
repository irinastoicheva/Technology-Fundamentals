namespace _02._SoftUni_Course_Planning
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
        public static void Main()
        {
            List<string> list = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();
            string command = Console.ReadLine();
            while (command != "course start")
            {
                string[] array = command.Split(":", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string com = array[0];
                string lessonTitle = array[1];
                switch (com)
                {
                    case "Add":
                        if (!list.Contains(lessonTitle))
                        {
                            list.Add(lessonTitle);
                        }
                        break;

                    case "Insert":
                        int index = int.Parse(array[2]);
                        list = Insert(list, index, lessonTitle);
                        break;

                    case "Remove":
                        list.Remove(lessonTitle);
                        string exercise = lessonTitle + "-Exercise";
                        list.Remove(exercise);
                        break;

                    case "Swap":
                        string lessonTitle2 = array[2];
                        list = Swap(list, lessonTitle, lessonTitle2);
                        break;

                    case "Exercise":
                        list = Exercise(list, lessonTitle);
                        break;

                }
                command = Console.ReadLine();
            }
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine($"{i+1}.{list[i]}");
            }
        }

        public static List<string> Exercise(List<string> list, string lessonTitle)
        {
            string exercise = lessonTitle + "-Exercise";
            bool haveLesson = false;
            bool haveExercise = false;
            int indexLesson = 0;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == lessonTitle)
                {
                    haveLesson = true;
                    indexLesson = i;
                }
            }
            if (!haveLesson)
            {
                list.Add(lessonTitle);
            }
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == exercise)
                {
                    haveExercise = true;
                    if (indexLesson + 1 != i)
                    {
                        list.Remove(exercise);
                    }
                }
            }
            if (!haveExercise)
            {
                if (indexLesson == list.Count)
                {
                    list.Add(exercise);
                }
                else
                {
                    list.Insert(indexLesson + 1, exercise);
                }
            }
            return list;
        }

        public static List<string> Swap(List<string> list, string lessonTitle, string lessonTitle2)
        {

            int index1 = list.IndexOf(lessonTitle);
            int index2 = list.IndexOf(lessonTitle2);
            if (index1 != -1 && index2 != -1)
            {
                list[index1] = lessonTitle2;
                list[index2] = lessonTitle;

                if (index1 + 1 < list.Count && list[index1 + 1] == $"{lessonTitle}-Exercise")
                {
                    list.RemoveAt(index1 + 1);
                    index1 = list.IndexOf(lessonTitle);
                    list.Insert(index1 + 1, $"{lessonTitle}-Exercise");
                }

                if (index2 + 1 < list.Count && list[index2 + 1] == $"{lessonTitle2}-Exercise")
                {
                    list.RemoveAt(index2 + 1);
                    index2 = list.IndexOf(lessonTitle2);
                    list.Insert(index2 + 1, $"{lessonTitle2}-Exercise");
                }
            }
            return list;
        }

        public static List<string> Insert(List<string> list, int index, string lessonTitle)
        {
            bool haveNot = false;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == lessonTitle)
                {
                    haveNot = true;
                }
            }
            if (haveNot || index < 0 || index > list.Count)
            {
                return list;
            }
            else
            {
                if (index == list.Count)
                {
                    list.Add(lessonTitle);
                }
                else
                {
                    list.Insert(index, lessonTitle);
                }
                return list;
            }
        }
    }
}
