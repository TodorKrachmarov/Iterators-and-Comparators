using System;
using System.Collections;
using System.Collections.Generic;

public class MyStack<T> : IMyStack<T>
{
    public MyStack()
    {
        this.Data = new List<T>();
    }

    public IEnumerator<T> GetEnumerator()
    {
        for (int i = this.Data.Count - 1; i >= 0; i--)
        {
            yield return this.Data[i];
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }

    public IList<T> Data { get; private set; }

    public void Push(T element)
    {
        this.Data.Add(element);
    }

    public T Pop()
    {
        if (this.Data.Count == 0)
        {
            throw new ArgumentException("No elements");
        }
        T element = this.Data[this.Data.Count - 1];
        this.Data.RemoveAt(this.Data.Count - 1);
        return element;
    }
}
