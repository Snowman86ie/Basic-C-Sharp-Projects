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
            Employee employee = new Employee();
            employee.Name = new List<string>();
           
            
                        
            employee.Name.Add("Liam Curtin");
            employee.Name.Add("Joe Smith");

            if (employee.Id != employee.Id)
            {
                Console.WriteLine("They are a match");
            }
            else
            {
                Console.WriteLine("They are not a match");
            }

            //person.SayName();


            Console.ReadLine();
        }
    }
}
