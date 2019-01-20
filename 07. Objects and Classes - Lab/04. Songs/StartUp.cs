namespace _04._Songs
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Song
    {
        public string Type {get; set;}
        public string Name {get; set;}
        public string HoursAndMinutes { get; set; }
    }

    class StartUp
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            List<Song> songs = new List<Song>();

            for (int i = 0; i < number; i++)
            {
                string[] input = Console.ReadLine().Split('_').ToArray();
                string type = input[0];
                string name = input[1];
                string hoursAndMinutes = input[2];

                Song song = new Song
                {
                    Type = type,
                    Name = name,
                    HoursAndMinutes = hoursAndMinutes
                };
                songs.Add(song);
            }
            string typePrint = Console.ReadLine();
            if (typePrint != "all")
            {
                songs = songs.Where(x => x.Type == typePrint).ToList();
            }
            foreach (var item in songs)
            {
                Console.WriteLine(item.Name);
            }
        }
    }
}
