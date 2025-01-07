using ObjectAdapterPattern.Adapter;
using ObjectAdapterPattern.Interface;

namespace ObjectAdapterPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<List<string>> employeesRawData = [];
            employeesRawData.Add(["Sachin K", "SSE", "650000"]);
            employeesRawData.Add(["Raju S", "Lead", "800000"]);
            employeesRawData.Add(["Anil D", "SE", "580000"]);
            employeesRawData.Add(["Vijay C", "Architect", "900000"]);
            employeesRawData.Add(["Chetan P", "Manager", "1200000"]);

            ITarget target = new EmployeeAdapter();
            target.ProcessCompanySalary(employeesRawData);

            Console.WriteLine("........................................................................");
            Console.Read();
        }
    }
}
