using DesignPatterns.Patterns.MediatorPattern.Stands;

namespace DesignPatterns.Patterns.MediatorPattern
{
    internal class ConcessionMediator : IConsessionMediator
    {
        private readonly List<IConsessionStand> Consessions = new();

        public NorthConcessionStand NorthConcessions
        {
            set
            {
                var stand = Consessions.FirstOrDefault(c => c is NorthConcessionStand);
                if (stand != null)
                    Consessions.Remove(stand);
                Consessions.Add(value);
            }
        }

        public SouthConcessionStand SouthConcessions
        {
            set
            {
                var stand = Consessions.FirstOrDefault(c => c is SouthConcessionStand);
                if (stand != null)
                    Consessions.Remove(stand);
                Consessions.Add(value);
            }
        }

        /// <summary>
        /// Notify all colleagues but the <paramref name="senderStand"/>
        /// </summary>
        public void SendMessage(string message, IConsessionStand senderStand)
        {
            foreach (var consession in Consessions.Where(c => c != senderStand))
                consession.Notify(message);
        }
    }
}
