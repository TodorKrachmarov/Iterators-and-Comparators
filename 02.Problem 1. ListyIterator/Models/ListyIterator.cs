using System;
using System.Collections;
using System.Collections.Generic;

public class ListyIterator<T> : IListyIterator<T>//, IEnumerable<T>
{
    public ListyIterator(params T[] data)
    {
        this.Reset();
        this.Data = new List<T>(data);
    }

    public IReadOnlyList<T> Data { get; private set; }

    public int CurrentIndex { get; private set; }

    public void Reset()
    {
        this.CurrentIndex = 0;
    }

    public bool Move()
    {
        return ++this.CurrentIndex < this.Data.Count;
    }

    public bool HasNext()
    {
        return this.CurrentIndex < this.Data.Count - 1;
    }

    public void Print()
    {
        if (this.Data.Count == 0)
        {
            throw new ArgumentException("Invalid Operation!");
        }
        if (this.CurrentIndex >= this.Data.Count)
        {
            Console.WriteLine(this.Data[this.Data.Count - 1]);
        }
        else
        {
            Console.WriteLine(this.Data[CurrentIndex]);
        }
    }

    public IEnumerator<T> GetEnumerator()
    {
        for (int i = 0; i < this.Data.Count; i++)
        {
            yield return this.Data[i];
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }
}
