namespace _04._Reverse_Array_of_Strings
{
    using System;
    using System.Linq;
    class StartUp
    {
        static void Main()
        {
            string[] arr = Console.ReadLine().Split().ToArray();
            Console.WriteLine(string.Join(" ", arr.Reverse()));
        }
    }
}
