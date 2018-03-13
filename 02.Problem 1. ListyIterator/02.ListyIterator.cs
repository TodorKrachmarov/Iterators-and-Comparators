using System;
using System.Linq;

public class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        IListyIterator<string> myListyIterator = new ListyIterator<string>(input.Split().Skip(1).ToArray());

        while ((input = Console.ReadLine()) != "END")
        {
            try
            {
                switch (input)
                {
                    case "Move":
                        Console.WriteLine(myListyIterator.Move());
                        break;
                    case "HasNext":
                        Console.WriteLine(myListyIterator.HasNext());
                        break;
                    case "Print":
                        myListyIterator.Print();
                        break;
                    case "PrintAll":
                        foreach (var element in myListyIterator)
                        {
                            Console.Write(element + " ");
                        }
                        Console.WriteLine();
                        break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
