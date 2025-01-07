using BuilderPattern.Builder;
using BuilderPattern.Director;

namespace Builder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var travelAgent = new TravelAgent();
            var packageBuilder = new HolidayPackageBuilder();

            travelAgent.CreatePackage(packageBuilder, true, true, true, ["Beach trip", "Mountain hiking", "Desert Safari", "Sky Dive"]);

            var holidayPackage = packageBuilder.GetPackage();
            holidayPackage.DisplayPackageDetails();

            Console.ReadKey();
        }
    }
}
