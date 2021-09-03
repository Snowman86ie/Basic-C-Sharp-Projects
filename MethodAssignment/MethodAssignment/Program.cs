using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Method Assignment");
            Console.WriteLine();
            Console.WriteLine("Please enter a number below:");
            int userNumber = Convert.ToInt32(Console.ReadLine());

            int result1 = Math.Double(userNumber);
            Console.WriteLine("Double your number is: " + result1);
            Console.WriteLine();
            int result2 = Math.product(userNumber);
            Console.WriteLine("Your number mutliplied by itself is: " + result2);
            Console.WriteLine();
            int result3 = Math.divide(userNumber);
            Console.WriteLine("Your number divied by two is: " + result3);

            Console.ReadLine();
        }


    }
}
