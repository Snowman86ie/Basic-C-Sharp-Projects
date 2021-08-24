using System;

namespace Boolean_Logic_Submission
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Car Insurance Approval");
            Console.WriteLine();

            Console.WriteLine("Please answer the following questions.");
            Console.WriteLine("What is your age?");
            string age = Console.ReadLine();
            int PersonAge = Convert.ToInt32(age);
            Console.WriteLine("Have you ever had a DUI violation? Please answer \"true\" or \"false\".");
            string temp = Console.ReadLine();
            bool dui = Convert.ToBoolean(temp);
            Console.WriteLine("How many speeding tickets do you have?");
            string speed = Console.ReadLine();
            int SpeedingTickets = Convert.ToInt32(speed);
            Console.WriteLine();

            Console.WriteLine("Qualified?");
            Console.WriteLine(PersonAge > 15 && dui == false && SpeedingTickets == 0);


            Console.ReadLine();
        }
    }
}
