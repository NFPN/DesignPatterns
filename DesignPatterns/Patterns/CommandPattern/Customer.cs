using DesignPatterns.Patterns.CommandPattern.Commands;

namespace DesignPatterns.Patterns.CommandPattern
{
    /// <summary>
    /// The Invoker class
    /// </summary>
    public class Customer
    {
        private OrderCommandBase? orderCommand;
        private MenuItem? menuItem;
        private readonly FastFoodOrder order;

        public Customer() => order = new FastFoodOrder();

        public void SetCommand(int commandOption)
            => orderCommand = CommandFactory.GetCommand(commandOption);

        public void SetMenuItem(MenuItem item)
            => menuItem = item;

        public void ExecuteCommand()
        {
            if (orderCommand != null && menuItem != null)
                order.ExecuteCommand(orderCommand, menuItem);
        }

        public void ShowCurrentOrder()
            => order.ShowCurrentItems();
    }
}
