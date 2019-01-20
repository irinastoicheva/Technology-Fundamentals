namespace _01._Data_Balance
{
    using System;
    using System.Linq;
    class StartUp
    {
        static void Main()
        {
            int countOfInputs = int.Parse(Console.ReadLine());
            int[] averageValues = new int[countOfInputs];
            averageValues = GetAverageValues(averageValues, countOfInputs);
           
            int d = int.Parse(Console.ReadLine());

            int minValue = int.MaxValue;
            bool haveZero = false;
            for (int i = 0; i < averageValues.Length; i++)
            {
                if (averageValues[i] < minValue && averageValues [i] % d != 0 && averageValues [i] != 0)
                {
                    minValue = averageValues[i];
                }
                if (averageValues [i] == 0)
                {
                    haveZero = true;
                }
            }
            if (haveZero && minValue > 0)
            {
                minValue = 0;
            }
            PrintMessage(minValue, countOfInputs);
        }

        public static void PrintMessage(int minValue, int countOfInputs)
        {
            if (minValue > 0)
            {
                Console.WriteLine($"The inputs seem to be positively weighted. Positive weight: {minValue}");
            }
            else if (minValue == 0)
            {
                Console.WriteLine($"The inputs seem to be perfectly balanced, as all things should be. Count of all arrays: {countOfInputs}.");
            }
            else
            {
                Console.WriteLine($"The inputs seem to be negatively weighted. Negative weight: {minValue}");
            }
        }

        public static int[] GetAverageValues(int[] averageValues, int countOfInputs)
        {
            for (int i = 0; i < countOfInputs; i++)
            {
                double[] array = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
                double sum = 0.0;
                int counter = 0;
                for (int j = 0; j < array.Length; j++)
                {
                    sum += array[j];
                    counter++;
                }
                sum /= counter;
                int number = (int)Math.Ceiling(sum);
                averageValues[i] = number;
            }
            return averageValues;
        }
    }
}
