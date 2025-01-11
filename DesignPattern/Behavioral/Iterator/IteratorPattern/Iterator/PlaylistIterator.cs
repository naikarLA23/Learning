namespace IteratorPattern.Iterator
{
    internal class PlaylistIterator(List<Song> songs) : IIterator<Song>
    {
        private List<Song> Songs { get; set; } = songs;

        int _index = 0;

        public bool HasNext() => _index < Songs.Count;
        public bool HasPrevious() => _index > 0;

        public Song Next() => Songs[_index++];

        public Song Previous() => Songs[--_index];
    }
}
