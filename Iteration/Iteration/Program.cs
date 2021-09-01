using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Console App Assignment");
        Console.WriteLine();

        List<string> names = new List<string>{ "Jessie", "Dave", "Alan", "Paul" };
        List<string> updatednames = new List<string>();
        Console.WriteLine("Please enter a name:");
        string data = Console.ReadLine();
        Console.WriteLine();
       
        for (int i =0; i<names.Count; i++)
        {
            if (names.Count >= i)
            {
                names.Add(data);
            }
        }

        foreach (string name in names)
        {
            Console.WriteLine(name);
        }
        Console.ReadLine();

    }

}

