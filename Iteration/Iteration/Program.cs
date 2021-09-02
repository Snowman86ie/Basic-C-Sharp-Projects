using System;
using System.Collections.Generic;
using System.Linq;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Console App Assignment");
        Console.WriteLine();

        List<string> names = new List<string> { "Jessie", "Dave", "Alan", "Paul" };
        Console.WriteLine("Please enter a name:");
        string data = Console.ReadLine();
        Console.WriteLine();

        while (string.IsNullOrEmpty(data))
        {
            Console.WriteLine("Please enter a name:");
            data = Console.ReadLine();
        }
        if (!string.IsNullOrEmpty(data))
        {
            names.Add(data);
        }

        for (int i = 0; i < names.Count; i++)
        {
            Console.WriteLine(names[i]);
        }

        Console.WriteLine();
        List<string> pets = new List<string> { "dog", "cat", "bird", "snake", "horse", "goat" };
        Console.WriteLine("Please pick a favourite pet:");
        string pet = Console.ReadLine();

        while (string.IsNullOrEmpty(pet))
        {
            Console.WriteLine("Please pick a favourite pet:");
            pet = Console.ReadLine();
        }
        if (pets.Contains(pet))
        {
            for (int j = 0; j < pets.Count; j++)
            {
                if (pet == pets[j])
                {
                    Console.WriteLine("You pet is number " + j + " in the database.");
                    goto End;
                }
            }
        }
        else
        {
            Console.WriteLine("Your pet isn't in our database.");
        }

    End:

        List<string> greetings = new List<string> { "hi", "hello", "good day", "afternoon", "good night", "afternoon" };
        Console.WriteLine();
        Console.WriteLine("Please pick a favourite greeting:");
        string greet = Console.ReadLine();
        while (string.IsNullOrEmpty(greet))
        {
            Console.WriteLine("Please pick a favourite greeting:");
            greet = Console.ReadLine();
        }
        if (greetings.Contains(greet))
        {
            for (int j = 0; j < greetings.Count; j++)
            {
                if (greet == greetings[j])
                {
                    Console.WriteLine("Your greeting is number " + j + " in the database.");
                }
            }
        }
        else
        {
            Console.WriteLine("Your greeting isn't in our database.");
        }

        Console.WriteLine();
        List<string> items = new List<string> { "morning", "afternoon", "evening", "night", "morning" };
        List<string> duplicate = new List<string>();


        foreach (string item in items)
        {
            if (!duplicate.Contains(item))
            {
                duplicate.Add(item);
                Console.WriteLine(item + " " + " is not a duplicate");
            }
            else
            {
                Console.WriteLine(item + " " + "is a duplicate");
            }
        }
        Console.ReadLine();

    }
}

