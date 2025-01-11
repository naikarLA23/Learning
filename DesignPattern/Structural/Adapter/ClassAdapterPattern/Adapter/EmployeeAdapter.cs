using ClassAdapterPattern.Adaptee;
using ClassAdapterPattern.Interface;

namespace ClassAdapterPattern.Adapter
{
    internal class EmployeeAdapter : ThirdPartyBillingSystem, ITarget
    {
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

            ProcessSalary(employees);
        }
    }
}
