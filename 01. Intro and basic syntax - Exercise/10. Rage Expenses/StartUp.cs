namespace _10._Rage_Expenses
{
    using System;

    class StartUp
    {
        public static void Main()
        {
            int lostGames = int.Parse(Console.ReadLine());
            float headsetPrice = float.Parse(Console.ReadLine());
            float mousePrice = float.Parse(Console.ReadLine());
            float keyboardPrice = float.Parse(Console.ReadLine());
            float displayPrice = float.Parse(Console.ReadLine());

            int headsetCount = lostGames / 2;
            int mouseCount = lostGames / 3;
            int keyboardCount = lostGames / 6;
            int displayCount = lostGames / 12;

            float sum = headsetPrice * headsetCount + mousePrice * mouseCount + keyboardPrice * keyboardCount + displayPrice * displayCount;
            Console.WriteLine($"Rage expenses: {sum:F2} lv.");
        }
    }
}
