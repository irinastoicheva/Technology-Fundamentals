namespace MiTube___04___28._10._2018
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Video
    {
        public string Name { get; set; }
        public int Views { get; set; }
        public int Likes { get; set; }
    }
    class Program
    {
        static void Main()
        {
            List<Video> videos = new List<Video>();
            string command = Console.ReadLine();
            while (command != "stats time")
            {
                string[] input = command.Split('-').ToArray();

                if (input.Length == 2)
                {
                    string name = input[0];
                    int views = int.Parse(input[1]);

                    if (videos.Any(x => x.Name == name))
                    {
                        Video theVideo;
                        theVideo = videos.Find(x => (x.Name == name));
                        theVideo.Views += views;
                    }
                    else
                    {
                        Video video = new Video();
                        video.Name = name;
                        video.Views = views;
                        video.Likes = 0;
                        videos.Add(video);
                    }
                }
                else
                {
                    string[] input2 = command.Split(':').ToArray();
                    string name = input2[1];
                    string likes = input2[0];
                    int like = 0;

                    if (likes == "like")
                    {
                        like = 1;
                    }
                    else
                    {
                        like = -1;
                    }

                    if (videos.Any(x => x.Name == name))
                    {
                        Video theVideo;
                        theVideo = videos.Find(x => (x.Name == name));
                        theVideo.Likes += like;
                    }
                }

                command = Console.ReadLine();
            }

            command = Console.ReadLine();
            if (command == "by likes")
            {
                foreach (var item in videos.OrderByDescending(x => x.Likes))
                {
                    Console.WriteLine($"{item.Name} - {item.Views} views - {item.Likes} likes");
                }
            }
            else if (command == "by views")
            {
                foreach (var item in videos.OrderByDescending(x => x.Views))
                {
                    Console.WriteLine($"{item.Name} - {item.Views} views - {item.Likes} likes");
                }
            }
        }
    }
}
