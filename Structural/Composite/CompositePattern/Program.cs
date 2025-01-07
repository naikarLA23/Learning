using CompositePattern.Composite;
using CompositePattern.Interface;
using CompositePattern.Leaf;

namespace CompositePattern
{
    internal class Program
    {
        static void Main(string[] args)
        {

            DirectoryComponent myFolder = new DirectoryComponent("MyFolder");
            DirectoryComponent work = new DirectoryComponent("Work");
            DirectoryComponent personal = new DirectoryComponent("Personal");
            DirectoryComponent documents = new DirectoryComponent("Documents");
            DirectoryComponent tools = new DirectoryComponent("Tools");
            DirectoryComponent software = new DirectoryComponent("Software");

            IFileSystemComponent requirementDoc = new FileLeaf("Requirment.doc", 456832);
            IFileSystemComponent testReport = new FileLeaf("TestReport.xls", 785643);
            IFileSystemComponent mom = new FileLeaf("MOM.txt", 1087639);
            IFileSystemComponent design = new FileLeaf("Design.png", 456832);

            IFileSystemComponent extractTestReport = new FileLeaf("ExtractTestReport.exe", 456832);
            IFileSystemComponent extractDefects = new FileLeaf("ExtractDefects.exe", 456832);
            IFileSystemComponent runCodeAnalysis = new FileLeaf("RunCodeAnalysis.exe", 456832);

            IFileSystemComponent vscode = new FileLeaf("VSCode.exe", 456832);
            IFileSystemComponent msVisualStudio = new FileLeaf("MS VisualStudio 2022.exe", 456832);
            IFileSystemComponent postman = new FileLeaf("Postman.exe", 456832);


            IFileSystemComponent contactInfo = new FileLeaf("ContactInfo.txt", 456832);
            IFileSystemComponent broucher = new FileLeaf("Broucher.pdf", 785643);
            IFileSystemComponent id = new FileLeaf("ID.png", 1087639);
            IFileSystemComponent photo = new FileLeaf("Photo.png", 456832);

            myFolder.AddComponent(work);
            myFolder.AddComponent(personal);

            work.AddComponent(documents);
            work.AddComponent(tools);
            work.AddComponent(software);

            documents.AddComponent(requirementDoc);
            documents.AddComponent(testReport);
            documents.AddComponent(mom);
            documents.AddComponent(design);

            tools.AddComponent(extractTestReport);
            tools.AddComponent(extractDefects);
            tools.AddComponent(runCodeAnalysis);

            software.AddComponent(vscode);
            software.AddComponent(msVisualStudio);
            software.AddComponent(postman);

            personal.AddComponent(contactInfo);
            personal.AddComponent(broucher);
            personal.AddComponent(id);
            personal.AddComponent(photo);

            myFolder.DisplaySizeInKb();

            Console.ReadLine();
        }
    }

}
