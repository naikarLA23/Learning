using IteratorPattern.Iterator;

namespace IteratorPattern.Aggregator
{
    internal interface IAggregator<T>
    {
        IIterator<T> CreateIterator();
    }
}
