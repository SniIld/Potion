namespace Potion.Ingredients
{
    internal class Ingredient
    {
        Gamester gamester = new();

        protected int numberOfIngtrdients { get; set; }
        protected string name { get; set; }
        
        protected List<string> elements = new();
        protected List<string> notCompatibilityElement = new();

        public string CreatedPotion(params Ingredient[] ingredients)
        {
            List<string> notCompatibilityAllElements = new();
            List<string> elementsAllIngredients = new();

            
            foreach (var item in ingredients)
            {

                for (int i = 0; i < item.notCompatibilityElement.Count; i++)
                {
                    notCompatibilityAllElements.Add(item.notCompatibilityElement[i]);

                }

                for (int i = 0; i < item.elements.Count; i++)
                {
                    elementsAllIngredients.Add(item.elements[i]);
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
                if (elementsAllIngredients.Contains(item))
                {
                    return "Fail!";
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