using IteratorPattern.Aggregator;
using IteratorPattern.Iterator;

namespace IteratorPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PlaylistAggregator playlistAggregator = new PlaylistAggregator();
            playlistAggregator.AddSongToList(new("Zindagi ka safar", "K Kumar"));
            playlistAggregator.AddSongToList(new("Kantaara", "Vijay Kumar"));
            playlistAggregator.AddSongToList(new("Chand Taare", "Abhijeet"));
            playlistAggregator.AddSongToList(new("Mungaru Male", "Sonu Nigam"));
            playlistAggregator.AddSongToList(new("Why this Kolaveri", "Anirudh"));

            IIterator<Song> iterator = playlistAggregator.CreateIterator();

            Console.WriteLine("........................................................................");
            Console.WriteLine($"Playing forward song list....");
           
            Song song;
            while (iterator.HasNext())
            {
                song = iterator.Next();
                Console.WriteLine($"Song Title : {song.Title}.  Singer : {song.Singer}");
            }
            Console.WriteLine($"End of list");

            Console.WriteLine("........................................................................");
            Console.WriteLine($"Playing Reverse song list ....");
            while (iterator.HasPrevious())
            {
                 song = iterator.Previous();
                Console.WriteLine($"Song Title : {song.Title}.  Singer : {song.Singer}");
            }
            Console.WriteLine($"End of list");

            Console.WriteLine("........................................................................");
            Console.Read();
        }
    }
}
