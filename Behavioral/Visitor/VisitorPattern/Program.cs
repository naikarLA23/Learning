using VisitorPattern.Element;
using VisitorPattern.Element.ConcreteElement;
using VisitorPattern.Visitor;
using VisitorPattern.Visitor.ConcreteVisitor;

namespace VisitorPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IComputerPart> parts = new List<IComputerPart>()
            {
                new CPU("Dell CPU Core i7 Processor and Win 11 OS"),
                new DisplayMonitor("HP 25 inch LED Monitor"),
                new HardDisk("Seagate HDD"),
                new Printer("Laserjet printer"),
            };

            IComputerMaintainenceVisitor diagnosticCheckVisitor = new DiagnosticCheckVisitor("Diagnostic");
            IComputerMaintainenceVisitor statusCheckVisitor = new StatusCheckVisitor("status Check");

            foreach (var part in parts)
            {
                part.Accept(statusCheckVisitor);
            }

            Console.WriteLine("---------------------------------------------------------------------------------------------------");

            foreach (var part in parts)
            {
                part.Accept(diagnosticCheckVisitor);
            }

            Console.WriteLine("---------------------------------------------------------------------------------------------------");

            Console.ReadLine();
        }
    }
}
