using System;
using System.Collections.Generic;

public class Program
{
    static void Main(string[] args)
    {
        SortedSet<IPerson> peopleSortedByName = new SortedSet<IPerson>();
        HashSet<IPerson> peopleSortedByAge = new HashSet<IPerson>();
        int numberOfPoople = int.Parse(Console.ReadLine());

        for (int i = 0; i < numberOfPoople; i++)
        {
            string[] tolks = Console.ReadLine().Split();

            peopleSortedByName.Add(new Person(tolks[0], int.Parse(tolks[1])));
            peopleSortedByAge.Add(new Person(tolks[0], int.Parse(tolks[1])));
        }

        Console.WriteLine(peopleSortedByName.Count);
        Console.WriteLine(peopleSortedByAge.Count);

        //foreach (var person in peopleSortedByName)
        //{
        //    Console.WriteLine(person);
        //}

        //foreach (var person in peopleSortedByAge)
        //{
        //    Console.WriteLine(person);
        //}
    }
}
