using System;
using System.Collections.Generic;

public class Program
{
    static void Main(string[] args)
    {
        IList<IPerson> people = new List<IPerson>();
        string input;

        while ((input = Console.ReadLine()) != "END")
        {
            string[] tolks = input.Split();

            people.Add(new Person(tolks[0], int.Parse(tolks[1]), tolks[2]));
        }

        int personIndex = int.Parse(Console.ReadLine()) - 1;

        IPerson person = people[personIndex];
        int equalCount = 0;
        int notEqualCount = 0;

        foreach (var per in people)
        {
            if (person.CompareTo(per) == 0)
            {
                equalCount++;
            }
            else
            {
                notEqualCount++;
            }
        }

        if (equalCount == 1)
        {
            Console.WriteLine("No matches");
        }
        else
        {
            Console.WriteLine($"{equalCount} {notEqualCount} {people.Count}");
        }
    }
}
