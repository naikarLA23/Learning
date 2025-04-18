using ChartApp.Server.Model;

namespace ChartApp.Server.Repo
{
    public class ChartData
    {
        public static List<Chart> GetData()
        {
            var rnd = new Random();
            return new List<Chart>()
            {
                 new (){ Data = rnd.Next(1, 40), Label = "Data1", BackgroundColor = "#5491DA" },
                new (){ Data =rnd.Next(1, 40), Label = "Data2", BackgroundColor = "#E74C3C" },
                new (){ Data = rnd.Next(1, 40), Label = "Data3", BackgroundColor = "#82E0AA" },
                new (){ Data = rnd.Next(1, 40), Label = "Data4", BackgroundColor = "#E5E7E9" }
            };
        }
    }
}
