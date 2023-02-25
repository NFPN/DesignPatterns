namespace DesignPatterns.Patterns.MediatorPattern
{
    public interface IConsessionStand
    {
        void Send(string message);
        void Notify(string message);
    }
}