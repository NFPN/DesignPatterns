namespace DesignPatterns.Patterns.MediatorPattern.Stands
{
    internal class SouthConcessionStand : ConsessionStandBase, IConsessionStand
    {
        public SouthConcessionStand(IConsessionMediator mediator) : base(mediator) { }

        public void Send(string message)
        {
            Console.WriteLine("South Concession Stand sends message: " + message);
            Mediator.SendMessage(message, this);
        }

        public void Notify(string message)
        {
            Console.WriteLine("South Concession Stand gets message: " + message);
        }
    }
}
