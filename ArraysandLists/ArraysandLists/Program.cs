using System;
using System.Collections.Generic;


class Program
{
    static void Main()
    {
        Console.WriteLine("Array Assignment");
        Console.WriteLine();
        //Array of strings
        string[] stringArray = { "hello", "Goodday", "Evening", "Afternoon", "Good Night" };
        int stringGuess;
        startString:
        Console.WriteLine("Please select a number between 0 and 4:");
        stringGuess = Convert.ToInt32(Console.ReadLine());

        if (stringGuess >= 0 && stringGuess <= 4)
        {
            Console.WriteLine("The word you picked is: " + stringArray[stringGuess]);
        }
        else
        {
            Console.WriteLine("You have selected an invalid number!");
            goto startString;
        }

        //Array of integers
        Console.WriteLine();
        int[] numArray = { 5, 2, 10, 200, 5000, 600, 2300 };
        int numguess;
        startINT:
        Console.WriteLine("Please select a number between 0 and 6:");
        numguess = Convert.ToInt32(Console.ReadLine());

        if (numguess >= 0 && numguess <= 6)
        {
            Console.WriteLine("The number you picked is: " + numArray[numguess]);
        }
        else
        { 
            Console.WriteLine("You have selected an invalid number!");
            goto startINT;
        }

        //List array
        Console.WriteLine();
        List<string> StringList = new List<string>();
        StringList.Add("Hello");
        StringList.Add("Good Morning");
        StringList.Add("Hi");
        StringList.Add("Hey");

        int ListGuess;
        startList:
        Console.WriteLine("Please select a number between 0 and 3:");
        ListGuess = Convert.ToInt32(Console.ReadLine());

        if (ListGuess >= 0 && ListGuess <= 3)
        {
            Console.WriteLine("The word you picked is: " + StringList[ListGuess]);
        }
        else
        {
            Console.WriteLine("You have selected an invalid number!");
            goto startList;
        }

        Console.ReadLine();
    }
}

