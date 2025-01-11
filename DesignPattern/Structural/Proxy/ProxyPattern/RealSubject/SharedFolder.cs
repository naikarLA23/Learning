using ProxyPattern.SubjectInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern.RealSubject
{
    internal class SharedFolder : ISharedFolder
    {
        public void ProvideRWAccessToFolder()
        {
            Console.WriteLine("Performing Read Write operation on the Shared Folder");
        }
    }
}
