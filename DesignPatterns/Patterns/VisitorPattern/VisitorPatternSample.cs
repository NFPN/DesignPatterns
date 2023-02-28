using DesignPatterns.Patterns.VisitorPattern.Elements;
using DesignPatterns.Patterns.VisitorPattern.Visitors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.VisitorPattern
{
    internal class VisitorPatternSample : ISampleRunner
    {
        public void Run()
        {
            // Who are my employees?
            var employeeRoster = new Employees();
            employeeRoster.Attach(new LineCook());
            employeeRoster.Attach(new HeadChef());
            employeeRoster.Attach(new GeneralManager());

            // Employees are visited, giving them 10% raises 
            // and 3 extra paid time off days.
            employeeRoster.Accept(new IncomeVisitor());
            employeeRoster.Accept(new PaidTimeOffVisitor());
        }
    }
}
