using System;
using System.Text;


namespace Strings_Submission
{
    class Program
    {
        static void Main()
        {
            string firstname = "Liam";
            string phrase = "Hello world, i'm new to all this!";
            string lastname = "Jones";

            Console.WriteLine(phrase + " "+ firstname +" "+ lastname);

            firstname = firstname.ToUpper();
            Console.WriteLine(firstname);

            StringBuilder paragraph = new StringBuilder(phrase);
            Console.WriteLine(paragraph);
            paragraph.Append(" ");
            paragraph.Append(firstname);
            paragraph.Append(" ");
            Console.WriteLine(paragraph);
            paragraph.Append(lastname);
            Console.WriteLine(paragraph);

            Console.ReadLine();

        }
    }
}
