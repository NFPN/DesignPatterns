using DesignPatterns.Patterns.CommandPattern.Commands;

namespace DesignPatterns.Patterns.CommandPattern
{
    internal class FastFoodOrder
    {
        public List<MenuItem> CurrentItems { get; set; }

        public FastFoodOrder()
            => CurrentItems = new List<MenuItem>();

        public void ExecuteCommand(OrderCommandBase command, MenuItem item)
            => command.Execute(CurrentItems, item);

        public void ShowCurrentItems()
        {
            Console.WriteLine("-----------------------");
            Console.WriteLine("---   Order Items   ---");
            Console.WriteLine($"- {DateTime.UtcNow} -");
            Console.WriteLine("-----------------------");

            foreach (var item in CurrentItems)
                item.Display();
        }
    }
}