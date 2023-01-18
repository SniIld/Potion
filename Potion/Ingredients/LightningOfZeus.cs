namespace Potion.Ingredients
{
    internal class LightningOfZeus : Ingredient
    {
        private string[] elementsIncompatibleWithTheIngredient = { "Blood" };
        private string[] ingredientElements = { "Lightning", "Shine", "Sound", "Energy" };

        internal LightningOfZeus() 
        {
            name = "Lightning of Zeus";
            numberOfIngtrdients++;

            foreach (var item in elementsIncompatibleWithTheIngredient)
            {
                base.elementsIncompatibleWithTheIngredient.Add(item);
            }

            foreach (var item in ingredientElements)
            {
                base.ingredientElements.Add(item);
            }
        }
    }
}