using ProxyPattern.ProxyObject;
using ProxyPattern.RealSubject;
using ProxyPattern.SubjectInterface;

namespace ProxyPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ISharedFolder sharedFolder = new SharedFolder();
            Employee employee = new("Sanjay", "Manager");
            ShareFolderProxy shareFolderProxy = new(sharedFolder, employee);
            shareFolderProxy.ProvideRWAccessToFolder();
            Console.WriteLine("----------------------------------------------------------------");

            sharedFolder = new SharedFolder();
            employee = new("Vijay", "CEO");
            shareFolderProxy = new(sharedFolder, employee);
            shareFolderProxy.ProvideRWAccessToFolder();
            Console.WriteLine("----------------------------------------------------------------");

            sharedFolder = new SharedFolder();
            employee = new("Ravi", "Developer");
            shareFolderProxy = new(sharedFolder, employee);
            shareFolderProxy.ProvideRWAccessToFolder();
            Console.WriteLine("----------------------------------------------------------------");


            Console.ReadLine();
        }
    }
}
