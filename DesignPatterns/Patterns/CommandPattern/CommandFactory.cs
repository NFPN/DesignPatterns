using DesignPatterns.Patterns.CommandPattern.Commands;

namespace DesignPatterns.Patterns.CommandPattern
{
    public class CommandFactory
    {
        //Factory method
        public static OrderCommandBase GetCommand(int commandOption)
        {
            return commandOption switch
            {
                1 => new AddCommand(),
                2 => new ModifyCommand(),
                3 => new RemoveCommand(),
                _ => new AddCommand(),
            };
        }
    }
}
