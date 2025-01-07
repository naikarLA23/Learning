using BuilderPattern.Product;

namespace BuilderPattern.Builder
{
    internal abstract class AbstractHolidayPackageBuilder
    {
        protected HolidayPackage Package { get; private set; } = new HolidayPackage();

        internal abstract void BookFlight(string flightDetails);
        internal abstract void BookHotel(string hotelName);
        internal abstract void RentCar(string carDetails);
        internal abstract void AddExcursion(string excursion);

        internal HolidayPackage GetPackage() => Package;
    }
}
