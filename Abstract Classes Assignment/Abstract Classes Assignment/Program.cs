using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Classes_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee person = new Employee();

            person.FirstName = "Sample";
            person.LastName = "Student";

            person.SayName();

            person.Quit(person);


            Console.ReadLine();
        }
    }
}
