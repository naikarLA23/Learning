namespace IteratorPattern.Iterator
{
    internal interface IIterator<T>
    {
        T Next();
        T Previous();
        bool HasNext();
        bool HasPrevious();
    }
}
