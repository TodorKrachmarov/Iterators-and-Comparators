using System.Collections.Generic;

public class AgeCoparator : IComparer<IPerson>
{
    public int Compare(IPerson x, IPerson y)
    {
        return x.Age.CompareTo(y.Age);
    }
}
