using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structs_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Number number = new Number();
            number.Amount = 300.34m;

            Console.WriteLine(number.Amount);
            Console.ReadLine();
        }
    }

    public struct Number
    {
        public decimal Amount { get; set; }
    }
}
