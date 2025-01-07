namespace ClassAdapterPattern
{
    internal class Employee(string name, string designation, int salary)
    {
        internal string Name { get; set; } = name;
        internal string Designation { get; set; } = designation;
        internal int Salary { get; set; } = salary;
    }
}
