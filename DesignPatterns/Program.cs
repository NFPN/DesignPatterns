using DesignPatterns.Patterns;
using DesignPatterns.Patterns.CommandPattern;
using DesignPatterns.Patterns.MediatorPattern;

namespace DesignPatterns
{
    internal class Program
    {
        private static List<ISampleRunner> Samples => new()
        {
            new CommandPatternSample(),
            new MediatorPatternSample(),
        };

        private static void Main(string[] args)
        {
            if (Samples == null) return;

            Console.WriteLine("Running samples...\n");

            foreach (var sample in Samples)
            {
                sample.Run();

                Console.WriteLine($"\n\tFinished => {sample.GetType().Name}");

                var nextIndex = Samples.FindIndex(s => s.GetType() == sample.GetType()) + 1;

                if (nextIndex < Samples.Count)
                {
                    var nextSample = Samples[nextIndex];
                    Console.WriteLine($"\tNext => {nextSample.GetType().Name} \n");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }
    }
}