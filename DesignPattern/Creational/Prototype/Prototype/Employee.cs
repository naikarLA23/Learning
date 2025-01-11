namespace PrototypePattern.Prototype
{
    internal abstract class Employee
    {
        internal string FirstName { get; set; }
        internal string LastName { get; set; }
        internal short Age { get; set; }
        internal int Salary { get; set; }
        internal string Department { get; set; }
        internal string Type { get; set; }
        internal ConcreteAddress Address { get; set; }

        internal abstract Employee GetClone();
        internal abstract void ShowDetails();
    }
}
