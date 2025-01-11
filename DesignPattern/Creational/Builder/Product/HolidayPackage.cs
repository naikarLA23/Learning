namespace BuilderPattern.Product
{
    internal class HolidayPackage
    {
        internal string Flight { get; set; }
        internal string Hotel { get; set; }
        internal string CarRental { get; set; }
        internal List<string> Excursions { get; private set; } = new();

        internal void DisplayPackageDetails()
        {
            Console.WriteLine($"Flight: {Flight ?? "Not selected"}");
            Console.WriteLine($"Hotel: {Hotel ?? "Not selected"}");
            Console.WriteLine($"Car Rental: {CarRental ?? "Not selected"}");
            Console.WriteLine("Excursions: " + (Excursions.Any() ? string.Join(", ", Excursions) : "No excursions selected"));
        }
    }
}
