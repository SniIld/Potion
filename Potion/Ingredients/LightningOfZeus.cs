namespace Potion.Ingredients
{
    internal class LightningOfZeus : Ingredient
    {
        private string[] mainElementsIngredient = { "Lightning" };
        private string[] secondaryElementsIngredient = { "Shine", "Sound", "Energy" };
        private string[] elementsIncompatibleWithTheIngredient = { "Blood" };

        internal LightningOfZeus() 
        {
            name = "Lightning of Zeus";
            numberOfIngtrdients++;

            foreach (var item in mainElementsIngredient)
            {
                base.mainElementsIngredient.Add(item);
            }

            foreach (var item in secondaryElementsIngredient)
            {
                base.secondaryElementsIngredient.Add(item);
            }

            foreach (var item in elementsIncompatibleWithTheIngredient)
            {
                base.elementsIncompatibleWithTheIngredient.Add(item);
            }
        }
    }
}