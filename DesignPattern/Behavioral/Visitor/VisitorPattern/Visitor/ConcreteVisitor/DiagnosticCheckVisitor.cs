﻿using VisitorPattern.Element.ConcreteElement;

namespace VisitorPattern.Visitor.ConcreteVisitor
{
    internal class DiagnosticCheckVisitor(string visitorName) : IComputerMaintainenceVisitor
    {
        public string VisitorName { get; set; } = visitorName;

        public void Visit(DisplayMonitor monitor)
        {
            Console.WriteLine($"{VisitorName} : Doing diagnostic check for part : {monitor.PartName}");
        }

        public void Visit(CPU cpu)
        {
            Console.WriteLine($"{VisitorName} : Doing diagnostic check for part : {cpu.PartName}");
        }

        public void Visit(HardDisk hardDisk)
        {
            Console.WriteLine($"{VisitorName} : Doing diagnostic check for part : {hardDisk.PartName}");
        }

        public void Visit(Printer printer)
        {
            Console.WriteLine($"{VisitorName} : Doing diagnostic check for part : {printer.PartName}");
        }
    }
}
