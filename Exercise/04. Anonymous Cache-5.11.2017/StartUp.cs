namespace _04._Anonymous_Cache_5._11._2017
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
        public static void Main()
        {
            Dictionary<string, List<string>> cache = new Dictionary<string, List<string>>();
            Dictionary<string, Dictionary<string, int>> setKaySize = new Dictionary<string, Dictionary<string, int>>();
            string input = Console.ReadLine();
            while (input != "thetinggoesskrra")
            {
                string[] line = input.Split(new string[] { "->", "|" }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                string dataSet = string.Empty;
                string dataKey = string.Empty;
                int dataSize;
                if (line.Length==1)
                {
                    dataSet = line[0];
                    if (!setKaySize.ContainsKey(dataSet))
                    {
                        setKaySize.Add(dataSet, new Dictionary<string, int>());
                    }
                    if (cache.ContainsKey(dataSet))
                    {
                        dataKey = cache[dataSet][0];
                        dataSize = int.Parse(cache[dataSet][1]);
                        cache.Remove(dataSet);
                    }
                }
                else
                {
                    dataSet = line[2];
                    if (!setKaySize.ContainsKey(dataSet))
                    {
                        setKaySize.Add(dataSet, new Dictionary<string, int>());
                    }
                    if (cache.ContainsKey(dataSet))
                    {
                        dataKey = cache[dataSet][0];
                        dataSize = int.Parse(cache[dataSet][1]);
                        cache.Remove(dataSet);
                    }
                }
            }
        }
    }
}
