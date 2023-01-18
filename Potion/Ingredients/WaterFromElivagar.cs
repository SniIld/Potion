namespace Potion.Ingredients
{
    internal class WaterFromElivagar : Ingredient
    {
        private string[] mainElementsIngredient = { "Water" };
        private string[] secondaryElementsIngredient = { "Life", "Time" };
        private string[] elementsIncompatibleWithTheIngredient = { "Air" };

        internal WaterFromElivagar()
        {
            name = "Water from Elivagar";
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