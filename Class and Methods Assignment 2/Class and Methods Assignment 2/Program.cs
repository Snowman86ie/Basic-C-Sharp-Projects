using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_and_Methods_Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Class and Method Assignment 2");
            Console.WriteLine();
            Console.WriteLine("You dont need to enter a second value");
            Console.WriteLine("Please enter your first number below:");
            int userNumber1 = Convert.ToInt32(Console.ReadLine());
            int userNumber2;
            Console.WriteLine();
            Console.WriteLine("Do you wish to enter a second number? y/n");
            string answer = Console.ReadLine();

            if (answer == "y")
            {
                Console.WriteLine("Please enter a number below:");
                userNumber2 = Convert.ToInt32(Console.ReadLine());
                int result = Math.Addition(userNumber1, userNumber2);
                Console.WriteLine("The sum of the 2 numbers is: " + result);
            }
            else if (answer=="n")
            {
                int result = Math.Addition(userNumber1, userNumber2 =0);
                Console.WriteLine("The sum of the 2 numbers is: " + result);
            }
                        
            
            Console.ReadLine();
        }

        
    }
}
