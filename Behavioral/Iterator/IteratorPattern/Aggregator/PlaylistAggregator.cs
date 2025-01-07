using IteratorPattern.Iterator;

namespace IteratorPattern.Aggregator
{
    internal class PlaylistAggregator : IAggregator<Song>
    {
        private List<Song> Songs  = new();

        public IIterator<Song> CreateIterator()
        {
            return new PlaylistIterator(Songs);
        }

        public void AddSongToList(Song song)
        {
            Songs.Add(song);
        }
    }
}
