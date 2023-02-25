namespace DesignPatterns.Patterns.CommandPattern.Commands
{
    /// <summary>
    /// The Command abstract class
    /// </summary>
    public abstract class OrderCommandBase
    {
        public abstract void Execute(List<MenuItem> order, MenuItem newItem);
    }
}