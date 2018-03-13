using System.Collections.Generic;

public interface IListyIterator<T> : IEnumerable<T>
{
    IReadOnlyList<T> Data { get; }
    int CurrentIndex { get; }
    void Reset();
    bool Move();
    bool HasNext();
    void Print();
}
