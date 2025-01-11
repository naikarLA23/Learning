using ObjectAdapterPattern.Adaptee;
using ObjectAdapterPattern.Interface;

namespace ObjectAdapterPattern.Adapter
{
    internal class EmployeeAdapter : ITarget
    {
        ThirdPartyBillingSystem _billingSystem = new();
        public void ProcessCompanySalary(List<List<string>> employeesRawData)
        {
            List<Employee> employees = [];
            foreach (var employeeData in employeesRawData)
            {
                try
                {
                    employees.Add(new(employeeData[0], employeeData[1], int.Parse(employeeData[2])));
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error :{ex.Message}");
                }
            }

            _billingSystem.ProcessSalary(employees);
        }
    }
}
