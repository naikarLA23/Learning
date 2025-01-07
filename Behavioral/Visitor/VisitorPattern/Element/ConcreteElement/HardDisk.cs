using VisitorPattern.Visitor;

namespace VisitorPattern.Element.ConcreteElement
{
    internal class HardDisk(string partName) : IComputerPart
    {
        public string PartName { get; set; } = partName;

        public void Accept(IComputerMaintainenceVisitor compVisitor)
        {
            compVisitor.Visit(this);
        }
    }
}
