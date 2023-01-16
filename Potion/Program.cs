using Potion.Ingredients;

namespace Potion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ingredient ingredient = new();
            
            WaterFromElivagar waterFromElivagar = new();
            LightningOfZeus lightningOfZeus = new();

            Console.WriteLine(ingredient.CreatedPotion(waterFromElivagar, lightningOfZeus));
        }
    }
}