using DesignPatterns.Patterns.CommandPattern.Commands;

namespace DesignPatterns.Patterns.CommandPattern
{
    /// <summary>
    /// Responsible for generating the concrete classes
    /// </summary>
    public class CommandFactory
    {
        public static OrderCommandBase GetCommand(int commandOption)
        {
            //Could use reflection to find commands based on Interface
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
