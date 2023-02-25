namespace DesignPatterns.Patterns.CommandPattern.Commands
{
    /// <summary>
    /// A concrete command
    /// </summary>
    public class AddCommand : OrderCommandBase
    {
        public override void Execute(List<MenuItem> order, MenuItem newItem)
            => order.Add(newItem);
    }
}