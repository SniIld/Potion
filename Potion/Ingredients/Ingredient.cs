namespace Potion.Ingredients
{
    internal class Ingredient
    {
        Random Randomrandom = new();
        Gamester gamester = new();

        protected int numberOfIngtrdients { get; set; }
        protected string name { get; set; }

        protected List<string> mainElementsIngredient = new();
        protected List<string> secondaryElementsIngredient = new();
        protected List<string> elementsIncompatibleWithTheIngredient = new();

        public string CreatePotion(params Ingredient[] ingredients)
        {
            List<string> mainElementsAllIngredient = new();
            List<string> secondaryElementsAllIngredients = new();
            List<string> notCompatibilityAllElements = new();
            
            
            foreach (var item in ingredients)
            {
                for (int i = 0; i < item.mainElementsIngredient.Count; i++)
                {
                    mainElementsAllIngredient.Add(item.mainElementsIngredient[i]);
                }

                for (int i = 0; i < item.secondaryElementsIngredient.Count; i++)
                {
                    secondaryElementsAllIngredients.Add(item.secondaryElementsIngredient[i]);
                }
                
                for (int i = 0; i < item.elementsIncompatibleWithTheIngredient.Count; i++)
                {
                    notCompatibilityAllElements.Add(item.elementsIncompatibleWithTheIngredient[i]);
                }

                if (item.numberOfIngtrdients <= 0)
                {
                    return $"You don't have {item.name}";
                }
                else
                {
                    item.numberOfIngtrdients--;
                }
            }

            foreach (var item in notCompatibilityAllElements)
            {
                if (mainElementsAllIngredient.Contains(item))
                {
                    return "Fail!";
                }
                else if (secondaryElementsAllIngredients.Contains(item))
                {
                    if (Randomrandom.Next(2) == 0)
                    {
                        return "Fail";
                    }
                }
            }

            if (gamester.numberOfEmptyFlask <= 0)
            {
                return "You don't have empty Flask";
            }

            return "SUCCESS!!!";
        }
    }
}