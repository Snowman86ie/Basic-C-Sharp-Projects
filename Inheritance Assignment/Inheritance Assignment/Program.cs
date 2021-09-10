using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee person = new Employee();
            person.Name = new List<string>();
                        
            person.Name.Add("Liam Curtin");
            person.Name.Add("Joe Smith");

            if (person.Id == person.Id)
            {
                Console.WriteLine("They are a match");
            }
            else
            {
                Console.WriteLine("They are not a match");
            }

            person.SayName();


            Console.ReadLine();
        }
    }
}
