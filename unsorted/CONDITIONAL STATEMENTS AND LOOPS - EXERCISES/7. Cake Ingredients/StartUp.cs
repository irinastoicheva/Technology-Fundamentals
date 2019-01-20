
namespace _7.Cake_Ingredients
{
    using System;
    public class tartUp
    {
        public static void Main()
        {
            string ingredientsCake = Console.ReadLine();
            int counter = 0;
            while (ingredientsCake != "Bake!")
            {
                counter++;
                Console.WriteLine($"Adding ingredient {ingredientsCake}.");
                ingredientsCake = Console.ReadLine();
            }
            Console.WriteLine($"Preparing cake with {counter} ingredients.");
        }
    }
}
