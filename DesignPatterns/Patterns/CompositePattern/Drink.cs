namespace DesignPatterns.Patterns.CompositePattern
{
    /// <summary>
    /// Component class
    /// </summary>
    public abstract class Drink
    {
        public int Calories { get; set; }
        public List<Drink> Flavors { get; set; }

        public Drink(int calories)
        {
            Calories = calories;
            Flavors = new List<Drink>();
        }

        /// <summary>
        /// "Flatten" method, returns all available flavors
        /// </summary>
        public void DisplayCalories()
        {
            Console.WriteLine($"{GetType().Name}: {Calories} calories.");
            foreach (var drink in Flavors)
                drink.DisplayCalories();
        }
    }
}
