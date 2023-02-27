using DesignPatterns.Patterns.CompositePattern.Drinks;
using DesignPatterns.Patterns.CompositePattern.Flavors;

namespace DesignPatterns.Patterns.CompositePattern
{
    internal class CompositePatternSample : ISampleRunner
    {
        public void Run()
        {
            var colas = new Cola(210);
            colas.Flavors.Add(new VanillaCola(215));
            colas.Flavors.Add(new CherryCola(210));

            var lemonLime = new LemonLime(185);
            var rootBeers = new RootBeer(195);
            rootBeers.Flavors.Add(new VanillaRootBeer(200));
            rootBeers.Flavors.Add(new StrawberryRootBeer(200));

            var sodaWater = new SodaWater(180);
            sodaWater.Flavors.Add(colas);
            sodaWater.Flavors.Add(lemonLime);
            sodaWater.Flavors.Add(rootBeers);

            sodaWater.DisplayCalories();
        }
    }
}