using System;

public class Person : IPerson
{
    public Person(string name, int age)
    {
        this.Name = name;
        this.Age = age;
    }

    public string Name { get; private set; }

    public int Age { get; private set; }

    public override string ToString()
    {
        return $"{this.Name} {this.Age}";
    }

    public int CompareTo(IPerson other)
    {
        int nameResult = this.Name.ToLower().CompareTo(other.Name.ToLower());
        int ageResult = this.Age.CompareTo(other.Age);

        if (nameResult == 0 && ageResult == 0)
        {
            return 0;
        }

        return 1;
    }
}
