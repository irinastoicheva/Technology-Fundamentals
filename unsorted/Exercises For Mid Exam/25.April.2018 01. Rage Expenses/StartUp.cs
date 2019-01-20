namespace _25.April._2018_01._Rage_Expenses
{
    using System;

    class StartUp
    {
        public static void Main()
        {
            int game = int.Parse(Console.ReadLine());
            decimal headsetPrice = decimal.Parse(Console.ReadLine());
            decimal mousePrice = decimal.Parse(Console.ReadLine());
            decimal keyboardPrice = decimal.Parse(Console.ReadLine());
            decimal displayPrice = decimal.Parse(Console.ReadLine());
            int headset = 0;
            int mouse = 0;
            int keyboard = 0;
            int display = 0;
            for (int i = 1; i <= game; i++)
            {
                if (i % 2 == 0)
                {
                    headset++;
                }
                if (i % 3 == 0)
                {
                    mouse++;
                }
                if (i % 6 == 0)
                {
                    keyboard++;
                }
                if (i % 12 == 0)
                {
                    display++;
                }
            }
            decimal totalPrice = (headset * headsetPrice) + (mouse * mousePrice) + (keyboard * keyboardPrice) + (display * displayPrice);
            Console.WriteLine($"Rage expenses: {totalPrice:F2} lv.");
        }
    }
}
