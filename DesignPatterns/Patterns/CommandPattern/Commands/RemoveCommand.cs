namespace DesignPatterns.Patterns.CommandPattern.Commands
{
    /// <summary>
    /// A concrete command
    /// </summary>
    public class RemoveCommand : OrderCommandBase
    {
        public override void Execute(List<MenuItem> order, MenuItem newItem)
            => order.Remove(order.Where(x => x.Name == newItem.Name).First());
        //=> order.Remove(newItem);
    }
}