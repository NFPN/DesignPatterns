namespace DesignPatterns.Patterns.MediatorPattern
{
    /// <summary>
    /// This class represents the entity involved in 
    /// the conversation that should receive messages.
    /// </summary>
    abstract class ConsessionStandBase
    {
        protected IConsessionMediator Mediator { get; set; }

        protected ConsessionStandBase(IConsessionMediator mediator)
            => Mediator = mediator;
    }
}
