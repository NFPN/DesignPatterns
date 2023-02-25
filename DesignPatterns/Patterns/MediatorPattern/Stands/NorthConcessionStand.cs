namespace DesignPatterns.Patterns.MediatorPattern.Stands
{
    internal class NorthConcessionStand : ConsessionStandBase, IConsessionStand
    {
        public NorthConcessionStand(IConsessionMediator mediator) : base(mediator) { }

        public void Send(string message)
        {
            Console.WriteLine("North Concession Stand sends message: " + message);
            Mediator.SendMessage(message, this);
        }

        public void Notify(string message)
        {
            Console.WriteLine("North Concession Stand gets message: " + message);
        }
    }
}
