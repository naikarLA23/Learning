using PrototypePattern.Prototype;

namespace PrototypePattern.ConcreteProtoType
{
    internal class PermanentEmployee : Employee
    {
        internal override Employee GetClone()
        {
            PermanentEmployee pEmployee = (PermanentEmployee)this.MemberwiseClone();
            pEmployee.Address = (ConcreteAddress)this.Address.GetClone();
            return pEmployee;
        }

        internal override void ShowDetails()
        {
            Console.WriteLine("Permanent Employee");
            Console.WriteLine($"Name:{this.FirstName} \n {this.LastName}\n  Department: {this.Department}\n  Type:{this.Type}\n  Age: {this.Age}\n  Salary: {this.Salary}");
            this.Address.ShowDetails();
        }
    }
}
