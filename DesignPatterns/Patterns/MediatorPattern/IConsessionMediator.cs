namespace DesignPatterns.Patterns.MediatorPattern
{
    /// <summary>
    /// Defines a send message method 
    /// which the concrete mediators must implement.
    /// </summary>
    internal interface IConsessionMediator
    {
        /// <summary>
        /// Notify all colleagues but the <paramref name="senderStand"/>
        /// </summary>
        void SendMessage(string message, IConsessionStand concessionStand);
    }
}
