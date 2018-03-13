using System.Collections.Generic;

public interface ILake : IEnumerable<int>
{
    IList<int> Data { get; }
}
