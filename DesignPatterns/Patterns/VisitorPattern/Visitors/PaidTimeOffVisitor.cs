using DesignPatterns.Patterns.VisitorPattern.Elements;

namespace DesignPatterns.Patterns.VisitorPattern.Visitors
{
    /// <summary>
    /// A Concrete Visitor class
    /// </summary>
    internal class PaidTimeOffVisitor : IVisitor
    {
        public void Visit(Element element)
        {
            if (element is not Employee employee)
                return;

            //Add extra days off
            employee.PaidTimeOffDays += 3;

            Console.WriteLine($"{employee.GetType().Name} {employee.Name}'s new vacation days {employee.PaidTimeOffDays}");
        }
    }
}
