using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Method_Assignment
{
    class Math
    {
        public void Division(int num1)
        {
            int result = num1 / 2;
            Console.WriteLine();
            Console.WriteLine("Your number divied by 2 is:" + result);
            
        }

        public static int Addition(int num1)
        {
            int result = num1 + 5;
            return result;
        }

        public static int Addition(int num1, int num2)
        {
            int result = num1 + num2;
            return result;
        }
    }
    static class Numbers
    {

    }
}
