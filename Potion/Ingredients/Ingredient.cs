namespace Potion.Ingredients
{
    abstract internal class Ingredient
    {
        protected int numberOfEmptyFlask { get; set; }
        protected string element { get; set; }

        protected List<string> compatibilityElement = new();
    }
}