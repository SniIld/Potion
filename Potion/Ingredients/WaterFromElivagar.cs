using System.Xml.Linq;

namespace Potion.Ingredients
{
    internal class WaterFromElivagar : Ingredient
    {
        private string[] notCompatibilityElementsWithWater = { "Air" };
        private string[] elementsThisIngredient = { "Water", "Life", "Time" };

        internal WaterFromElivagar()
        {
            name = "Water from Elivagar";
            numberOfIngtrdients++;

            foreach (var item in notCompatibilityElementsWithWater)
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