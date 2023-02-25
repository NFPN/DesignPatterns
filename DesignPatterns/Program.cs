using DesignPatterns.Patterns;
using DesignPatterns.Patterns.CommandPattern;

namespace DesignPatterns
{
    internal class Program
    {
        private static IEnumerable<ISampleRunner> Samples => new[]
        {
            new CommandPatternSample(),
            //new MediatorPatternSample(),
        };

        private static void Main(string[] args)
        {
            Console.WriteLine("Running samples...\n");

            foreach (var sample in Samples)
                sample.Run();
        }
    }
}