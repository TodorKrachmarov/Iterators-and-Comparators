using System;
using System.Data;
using System.Linq;
using System.Text;

public class Program
{
    static void Main(string[] args)
    {
        int[] input = Console.ReadLine().Split(new[] {' ', ','}, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse).ToArray();
        ILake lake = new Lake(input);

        StringBuilder sb = new StringBuilder();
        foreach (var stone in lake)
        {
            sb.Append(stone + ", ");
        }

        Console.WriteLine(sb.ToString().Trim(' ', ','));
    }
}
