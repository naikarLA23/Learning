using BuilderPattern.Builder;

namespace BuilderPattern.Director
{
    internal class TravelAgent
    {
        public void CreatePackage(AbstractHolidayPackageBuilder builder, bool wantsFlight, bool wantsHotel, bool wantsCar, IEnumerable<string> excursions)
        {
            if (wantsFlight) builder.BookFlight("Flight details: Boeing Emirates BLR-DXB IC009");
            if (wantsHotel) builder.BookHotel("Taj Hotel");
            if (wantsCar) builder.RentCar("SUV Model XYZ");
            foreach (var excursion in excursions)
            {
                builder.AddExcursion(excursion);
            }
        }
    }
}
