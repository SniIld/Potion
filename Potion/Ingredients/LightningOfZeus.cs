namespace Potion.Ingredients
{
    internal class LightningOfZeus : Ingredient
    {
        string[] compatibilityElementsWithLightning = { "Lightning", "Water", "Fire" };

        public LightningOfZeus() 
        {
            element = "Lightning";
            numberOfEmptyFlask++;

            foreach (var item in compatibilityElementsWithLightning)
            {
                compatibilityElement.Add(item);
            }
        }
    }
}