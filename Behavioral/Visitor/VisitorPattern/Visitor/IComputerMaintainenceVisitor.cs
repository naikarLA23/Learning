using VisitorPattern.Element.ConcreteElement;

namespace VisitorPattern.Visitor
{
    internal interface IComputerMaintainenceVisitor
    {
        string VisitorName { get; set; }
        void Visit(DisplayMonitor monitor);
        void Visit(CPU cpu);
        void Visit(HardDisk hardDisk);
        void Visit(Printer printer);
    }
}
