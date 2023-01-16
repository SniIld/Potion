namespace Potion.Ingredients
{
    internal class LightningOfZeus : Ingredient
    {
        private string[] notCompatibilityElementsWithLightning = { "Blood" };
        private string[] elementsThisIngredient = { "Lightning", "Shine", "Sound", "Energy" };

        internal LightningOfZeus() 
        {
            numberOfEmptyFlask++;

            foreach (var item in notCompatibilityElementsWithLightning)
            {
                notCompatibilityElement.Add(item);
            }

            foreach (var item in elementsThisIngredient)
            {
                elements.Add(item);
            }
        }
    }
}