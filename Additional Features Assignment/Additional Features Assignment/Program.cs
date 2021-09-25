using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Additional_Features_Assignment
{
    public class Program
    {
        public Program() : this(10)
        {
            int age = 10;
            Console.WriteLine(age);
            Console.ReadLine();
        }
        public Program(int age)
        {
            age = 5;
            Console.WriteLine(age);
            Console.ReadLine();

        }
        static void Main(string[] args)
        {
            Program program = new Program();
            const string name = "Additional Features";
            var data = 21;

            Console.WriteLine("We have {0} new {1}", data, name);

            Console.ReadLine();
        }
    }
}
