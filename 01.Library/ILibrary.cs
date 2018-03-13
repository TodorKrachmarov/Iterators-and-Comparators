using System.Collections.Generic;

public interface ILibrary
{
    IReadOnlyList<IBook> Books { get; }
}
