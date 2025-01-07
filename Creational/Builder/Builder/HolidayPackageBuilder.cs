namespace BuilderPattern.Builder
{
    internal class HolidayPackageBuilder : AbstractHolidayPackageBuilder
    {
        internal override void BookFlight(string flightDetails)
        {
            Package.Flight = flightDetails;
        }

        internal override void BookHotel(string hotelName)
        {
            Package.Hotel = hotelName;
        }

        internal override void RentCar(string carDetails)
        {
            Package.CarRental = carDetails;
        }

        internal override void AddExcursion(string excursion)
        {
            Package.Excursions.Add(excursion);
        }
    }
}