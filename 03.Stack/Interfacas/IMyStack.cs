using System.Collections.Generic;

public interface IMyStack<T> : IEnumerable<T>
{
    IList<T> Data { get; }
    void Push(T element);
    T Pop();
}
