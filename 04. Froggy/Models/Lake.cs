using System.Collections;
using System.Collections.Generic;

public class Lake : ILake
{
    public Lake(params int[] data)
    {
        this.Data = data;
    }

    public IEnumerator<int> GetEnumerator()
    {
        for (int i = 0; i < this.Data.Count; i++)
        {
            if (i % 2 == 0)
            {
                yield return this.Data[i];
            }
        }

        for (int i = this.Data.Count - 1; i >= 0; i--)
        {
            if (i % 2 != 0)
            {
                yield return this.Data[i];
            }
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }

    public IList<int> Data { get; private set; }
}
