namespace PrototypePattern.Prototype
{
    internal abstract class Address
    {
        internal string FlatNumber { get; set; }
        internal string AddressLine1 { get; set; }
        internal string AddressLine2 { get; set; }
        internal string PinCode { get; set; }
        internal string Area { get; set; }
        internal string City { get; set; }
        internal string State { get; set; }
        internal string Country { get; set; }

        internal abstract Address GetClone();
        internal abstract void ShowDetails();
    }

    internal class ConcreteAddress : Address
    {
        internal override Address GetClone()
        {
            return (ConcreteAddress)this.MemberwiseClone();
        }

        internal override void ShowDetails()
        {
            Console.WriteLine($" Flat Number : {this.FlatNumber}\n  Area : {this.Area}\n  City : {this.City}\n  State : {this.State}\n  Country : {this.Country}\n  PinCode : {this.PinCode}");
        }
    }
}
