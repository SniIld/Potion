namespace Potion.Ingredients
{
    internal class WaterFromElivagar : Ingredient
    {
        private string[] elementsIncompatibleWithTheIngredient = { "Air" };
        private string[] ingredientElements = { "Water", "Life", "Time" };

        internal WaterFromElivagar()
        {
            name = "Water from Elivagar";
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