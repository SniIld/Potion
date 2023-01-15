using System.Xml.Linq;

namespace Potion.Ingredients
{
    internal class WaterFromElivagar : Ingredient
    {
        string[] compatibilityElementsWithWater = { "Water", "Soil", "Lightning" };

        public WaterFromElivagar()
        {
            element = "Water";
            numberOfEmptyFlask++;

            foreach (var item in compatibilityElementsWithWater)
            {
                compatibilityElement.Add(item);
            }
        }
    }
}