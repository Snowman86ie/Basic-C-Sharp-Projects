using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> employee = new Employee<string>();
            employee.Things = new List<string>();

            employee.Things.Add("hello");
            employee.Things.Add("hi");
            employee.Things.Add("good day");

            employee.Print();

            Employee<int> employee1 = new Employee<int>();
            employee1.Things = new List<int>();
            employee1.Things.Add(1);
            employee1.Things.Add(2);
            employee1.Things.Add(3);

            employee1.Print();

            Console.ReadLine();
        }
    }
}
