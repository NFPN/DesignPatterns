using DesignPatterns.Patterns.VisitorPattern.Elements;

namespace DesignPatterns.Patterns.VisitorPattern.Visitors
{
    /// <summary>
    /// The Visitor interface, which declares 
    /// a Visit operation for each ConcreteVisitor to implement.
    /// </summary>
    internal interface IVisitor
    {
        void Visit(Element element);
    }
}
