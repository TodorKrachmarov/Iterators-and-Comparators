﻿public class Person : IPerson
{
    public Person(string name, int age, string town)
    {
        this.Name = name;
        this.Age = age;
        this.Town = town;
    }

    public string Name { get; private set; }

    public int Age { get; private set; }

    public string Town { get; private set; }

    public int CompareTo(IPerson otherPerson)
    {
        int result = this.Name.CompareTo(otherPerson.Name);

        if (result == 0)
        {
            result = this.Age.CompareTo(otherPerson.Age);
        }

        if (result == 0)
        {
            result = this.Town.CompareTo(otherPerson.Town);
        }

        return result;
    }
}

