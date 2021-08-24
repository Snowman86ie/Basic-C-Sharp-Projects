using System;

namespace Income_Comprassion_Submission
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Anonymous Income Comprasion Program");
            Console.WriteLine();

            Console.WriteLine("Person 1:");
            Console.WriteLine("Please enter hourly rate:");
            string rate1 = Console.ReadLine();
            decimal HourRate = Convert.ToDecimal(rate1);
            Console.WriteLine("Please enter your hours worked per week:");
            string hours1 = Console.ReadLine();
            decimal hoursWorked = Convert.ToDecimal(hours1);
            Console.WriteLine();

            Console.WriteLine("Person 2:");
            Console.WriteLine("Please enter hourly rate:");
            string rate2 = Console.ReadLine();
            decimal HourRate2 = Convert.ToDecimal(rate2);
            Console.WriteLine("Please enter your hours worked per week:");
            string hours2 = Console.ReadLine();
            decimal hoursWorked2 = Convert.ToDecimal(hours2);
            Console.WriteLine();

            decimal salaryPerson1 = (hoursWorked * HourRate) * 52;
            decimal salaryPerson2 = (hoursWorked2 * HourRate2) * 52;

            Console.WriteLine("Annual salary of Person 1:\n" + salaryPerson1);
            Console.WriteLine("Annual salary of Person 2:\n" + salaryPerson2);
            Console.WriteLine();

            Console.WriteLine("Does Person 1 makes more money than Person 2:");
            bool answer = salaryPerson1 > salaryPerson2;
            Console.WriteLine(answer.ToString());


            Console.ReadLine();
        }
    }
}
