using DesignPatterns.Patterns.VisitorPattern.Elements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.VisitorPattern.Visitors
{
    /// <summary>
    /// A Concrete Visitor class.
    /// </summary>
    internal class IncomeVisitor : IVisitor
    {
        public void Visit(Element element)
        {
            if (element is not Employee employee)
                return;

            //Salary raise
            employee.AnnualSalary *= 1.10;

            Console.WriteLine($"{employee.GetType().Name} {employee.Name}'s new income? {employee.AnnualSalary:C2}");
        }
    }
}
