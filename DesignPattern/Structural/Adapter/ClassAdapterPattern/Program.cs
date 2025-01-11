using ClassAdapterPattern.Adapter;
using ClassAdapterPattern.Interface;

namespace ClassAdapterPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<List<string>> employeesRawData = [];
            employeesRawData.Add(new List<string>() { "Sachin K", "SSE", "650000" });
            employeesRawData.Add(new List<string>() { "Raju S", "Lead", "800000" });
            employeesRawData.Add(new List<string>() { "Anil D", "SE", "580000" });
            employeesRawData.Add(new List<string>() { "Vijay C", "Architect", "900000" });
            employeesRawData.Add(new List<string>() { "Chetan P", "Manager", "1200000" });

            ITarget target = new EmployeeAdapter();
            target.ProcessCompanySalary(employeesRawData);

            Console.WriteLine("........................................................................");
            Console.Read();
        }
    }
}
