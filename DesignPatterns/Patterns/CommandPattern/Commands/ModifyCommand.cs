namespace DesignPatterns.Patterns.CommandPattern.Commands
{
    /// <summary>
    /// A concrete command
    /// </summary>
    public class ModifyCommand : OrderCommandBase
    {
        public override void Execute(List<MenuItem> order, MenuItem newItem)
        {
            var item = order.Where(x => x.Name == newItem.Name).First();
            item.Price = newItem.Price;
            item.Amount = newItem.Amount;
        }
    }
}