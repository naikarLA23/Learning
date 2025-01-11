using ProxyPattern.SubjectInterface;

namespace ProxyPattern.ProxyObject
{
    internal class ShareFolderProxy(ISharedFolder folder, Employee employee) : ISharedFolder
    {
        public Employee _Employee { get; set; } = employee;
        public ISharedFolder Folder { get; set; } = folder;

        public void ProvideRWAccessToFolder()
        {
            if(_Employee.Role == "Manager" || _Employee.Role =="CEO")
            {
                Console.WriteLine($"Provided access to user  {_Employee.Name} with role {_Employee.Role}");
                Folder.ProvideRWAccessToFolder();
            }
            else
            {
                Console.WriteLine($"Cannot provide access to user  {_Employee.Name} with role {_Employee.Role}");
            }
        }
    }
}
