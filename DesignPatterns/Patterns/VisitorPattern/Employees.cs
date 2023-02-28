using DesignPatterns.Patterns.VisitorPattern.Elements;
using DesignPatterns.Patterns.VisitorPattern.Visitors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.VisitorPattern
{
    /// <summary>
    /// The Object Structure class, which is a collection of Concrete Elements.  
    /// This could be implemented using another pattern such as Composite.
    /// </summary>
    internal class Employees
    {
        private readonly List<Employee> employees = new();


        public void Attach(Employee employee)
            => employees.Add(employee);

        public void Detach(Employee employee)
            => employees.Remove(employee);

        public void Accept(IVisitor visitor)
        {
            foreach (var employee in employees)
                employee.Accept(visitor);

            Console.WriteLine();
        }
    }
}
