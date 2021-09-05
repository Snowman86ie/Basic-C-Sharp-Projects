using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Method_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Math math = new Math();

            Console.WriteLine("Class Method Assignment");
            Console.WriteLine();
            Console.WriteLine("Please enter a number:");
            int userNumber = Convert.ToInt32(Console.ReadLine());
            math.Division(userNumber);
            Console.WriteLine();
            int result = Math.Addition(userNumber);
            Console.WriteLine("Your number plus five is:" + result);
            Console.WriteLine();
            int result2 = Math.Addition(userNumber, 15);
            Console.WriteLine("Your number plus 15 is:" + result2);


            Console.ReadLine();
        }
    }
}
