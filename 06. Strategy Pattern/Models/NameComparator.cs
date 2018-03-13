using System.Collections.Generic;

public class NameComparator : IComparer<IPerson>
{
    public int Compare(IPerson x, IPerson y)
    {
        int result = x.Name.Length.CompareTo(y.Name.Length);

        if (result == 0)
        {
            char xChar = x.Name.ToLower()[0];
            char yChar = y.Name.ToLower()[0];
            result = xChar.CompareTo(yChar);
        }

        return result;
    }
}
