using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_and_Method_Assignment_3
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Math math = new Math();
            
            int num1 = 3, num2 = 5;
            math.Addition(num1 , num2);
            Console.WriteLine();
            
            math.Addition(num1: 4, num2: 15);
            Console.ReadLine();
        }
    }
}
