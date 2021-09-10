using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Assignment
{
    public class Person
    {
        public List<string> Name{ get; set; } 
        

        public void SayName()
        {
            foreach (string name in Name)
            {
                Console.WriteLine("Name: " + name);
            }
          
        }

        public static bool operator ==(Employee employee)
        {
            if (employee.Equals(employee))
                return true;
            else
                return false;
            
        }
        public static bool operator!=(Employee employee)
        {
            if (!employee.Equals(employee))
                return true;
            else
                return false;
        }
    }
}
