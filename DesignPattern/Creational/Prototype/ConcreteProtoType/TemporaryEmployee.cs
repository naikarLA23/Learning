using PrototypePattern.Prototype;

namespace PrototypePattern.ConcreteProtoType
{
    internal class TemporaryEmployee : Employee
    {
        internal override Employee GetClone()
        {
            TemporaryEmployee pEmployee = (TemporaryEmployee)this.MemberwiseClone();
            pEmployee.Address = (ConcreteAddress)this.Address.GetClone();
            return pEmployee;
        }

        internal override void ShowDetails()
        {
            Console.WriteLine("Temporary Employee");
            Console.WriteLine($"Name:{this.FirstName} {this.LastName}\n  Department: {this.Department}\n  Type:{this.Type}\n  Age: {this.Age}\n  Salary: {this.Salary}");
            this.Address.ShowDetails();
        }
    }
}