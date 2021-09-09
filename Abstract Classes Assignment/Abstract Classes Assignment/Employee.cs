using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Classes_Assignment
{
    public class Employee : Person, IQuittable
    {
        public override void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
            base.SayName();
        }
        public void Quit(Employee employee)
        {
            Console.WriteLine(FirstName + LastName + " has quit there job");
        }
    }
}
