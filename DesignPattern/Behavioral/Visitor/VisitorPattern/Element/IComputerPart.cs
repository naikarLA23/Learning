using VisitorPattern.Visitor;

namespace VisitorPattern.Element
{
    internal interface IComputerPart
    {
        string PartName { get; set; }
        void Accept(IComputerMaintainenceVisitor compVisitor);
    }
}
