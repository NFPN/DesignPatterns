using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Patterns.VisitorPattern.Visitors;

namespace DesignPatterns.Patterns.VisitorPattern.Elements
{
    /// <summary>
    /// The Element abstract class.  All this does 
    /// is define an Accept operation, which needs 
    /// to be implemented by any class that can be visited.
    /// </summary>
    internal abstract class Element
    {
        public abstract void Accept(IVisitor visitor);
    }
}
