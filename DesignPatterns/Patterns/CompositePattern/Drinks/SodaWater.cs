namespace DesignPatterns.Patterns.CompositePattern.Drinks
{
    /// <summary>
    /// Composite class, root node
    /// </summary>
    public class SodaWater : Drink
    {
        public SodaWater(int calories) : base(calories) { }
    }
}