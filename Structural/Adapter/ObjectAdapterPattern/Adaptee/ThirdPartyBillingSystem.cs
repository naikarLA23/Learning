namespace ObjectAdapterPattern.Adaptee
{
    internal class ThirdPartyBillingSystem
    {
        internal void ProcessSalary(List<Employee> employees)
        {
            foreach (Employee employee in employees)
            {
                Console.WriteLine("Rs." + employee.Salary + " Salary Credited to " + employee.Name + " Account");
            }
        }
    }
}
