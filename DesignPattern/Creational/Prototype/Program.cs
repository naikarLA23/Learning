using PrototypePattern.ConcreteProtoType;
using PrototypePattern.Prototype;

namespace Prototype
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new PermanentEmployee()
            {
                FirstName = "Santosh",
                LastName = "Rao",
                Department = "IT",
                Type = "Permanent",
                Age  = 44,
                Address = new ConcreteAddress()
                {
                    FlatNumber = "R221",
                    Area = "Ram Nagar",
                    City = "Bangalore",
                    State = "Karnataka",
                    Country = "India",
                    PinCode="591101"
                },
                Salary = 900000
            };
            //Creating a Clone of the above Permanent Employee
            Employee emp2 = emp1.GetClone();
            emp2.FirstName = "Pranaya";
            emp2.LastName = "Chipli";
            emp2.Department = "Finance";
            emp2.Type = "Permanent";
            emp2.Age = 25;
            emp2.Address = new ConcreteAddress()
            {
                FlatNumber = "A541",
                Area = "Shiv Nagar",
                City = "Dharwad",
                State = "Karnataka",
                Country = "India",
                PinCode = "561211"
            };
            emp2.Salary = 300000;

            emp1.ShowDetails();
            Console.WriteLine("........................................................................");

            emp2.ShowDetails();
            Console.WriteLine("........................................................................");

            // Creating an Instance of Temporary Employee Class
            Employee emp3 = new TemporaryEmployee()
            {
                FirstName = "Praveen",
                LastName = "Arasu",
                Department = "Infra",
                Type = "Trmporary",
                Age = 29,
                Address = new ConcreteAddress()
                {
                    FlatNumber = "B787",
                    Area = "Shanthi Nagar",
                    City = "Mysore",
                    State = "Karnataka",
                    Country = "India",
                    PinCode = "579008"
                },
                Salary = 400000
            };


            //Creating a Clone of the above Temporary Employee
            Employee emp4 = emp3.GetClone();
            emp4.FirstName = "Kiran";
            emp4.LastName = "Shintre";
            emp4.Department = "Logistic";
            emp4.Type = "Temporary";
            emp4.Age = 34;
            emp4.Address = new ConcreteAddress()
            {
                FlatNumber = "A541",
                Area = "Dollar Colony",
                City = "Mangalore",
                State = "Karnataka",
                Country = "India",
                PinCode = "551321"
            };
            emp4.Salary = 350000;
            emp3.ShowDetails();
            Console.WriteLine("........................................................................");

            emp4.ShowDetails();
            Console.WriteLine("........................................................................");

            Console.Read();
        }
    }
}
