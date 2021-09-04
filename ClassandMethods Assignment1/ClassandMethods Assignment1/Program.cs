using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassandMethods_Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Math math = new Math();

            Console.WriteLine("Class and Method Assignment");
            Console.WriteLine();
            Console.WriteLine("Please enter a number below:");
            decimal userNumber = Convert.ToDecimal(Console.ReadLine());
            
            decimal result = Math.Addition(Convert.ToDecimal(userNumber));
            Console.WriteLine("Your number mutliplied by itself is: " + result);
            Console.WriteLine();
            Console.ReadLine();

            int result1 = Math.Addition(Convert.ToInt32(userNumber));
            Console.WriteLine("Double your number is: " + result1);
            Console.WriteLine();
            Console.ReadLine();

            string result2 = Math.Addition(Convert.ToString(userNumber)) ;
            int temp = Convert.ToInt32(result2);
            Console.WriteLine("Your number minus four is: " + result2);
            Console.WriteLine();
            Console.ReadLine();


        }
    }
}
