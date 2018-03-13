using System;
using System.Linq;

public class Program
{
    static void Main(string[] args)
    {
        IMyStack<int> stack = new MyStack<int>();
        string input;

        while ((input = Console.ReadLine()) != "END")
        {
            var tolks = input.Split(new []{' ', ','},StringSplitOptions.RemoveEmptyEntries).ToList();
            string command = tolks[0];
            tolks.RemoveAt(0);
            try
            {
                switch (command)
                {
                    case "Push":
                        foreach (var tolk in tolks)
                        {
                            stack.Push(int.Parse(tolk));
                        }
                        break;
                    case "Pop":
                        stack.Pop();
                        break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        foreach (var element in stack)
        {
            Console.WriteLine(element);
        }

        foreach (var element in stack)
        {
            Console.WriteLine(element);
        }
    }
}
