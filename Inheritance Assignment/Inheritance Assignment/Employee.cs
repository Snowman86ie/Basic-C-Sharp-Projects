using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Assignment
{
    public class Employee : Person
    {
        public int Id { get; set; }


        public static bool operator ==(Employee employee, Employee employee1)
        {
            if (employee.Id == employee1.Id)
                return true;
            else
                return false;

        }
        public static bool operator !=(Employee employee, Employee employee1)
        {
            if (employee.Id != employee1.Id)
                return true;
            else
                return false;
        }
    }

    
}
