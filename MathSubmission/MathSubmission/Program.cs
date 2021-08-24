using System;


namespace MathSubmission
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("please enter a number below:");
            string num1 = Console.ReadLine();
            int number1 = Convert.ToInt32(num1);
            int answer1 = number1 *50;
            Console.WriteLine("The number " + num1 + " multiplied by 50 is " + answer1.ToString());

            Console.WriteLine();
            Console.WriteLine("please enter a number below:");
            string num2 = Console.ReadLine();
            int number2 = Convert.ToInt32(num2);
            int answer2 = number2 + 25;
            Console.WriteLine("The number " + num2 + " plus 25 is " + answer2.ToString());

            Console.WriteLine();
            Console.WriteLine("please enter a number below:");
            string num3 = Console.ReadLine();
            double number3 = Convert.ToDouble(num3);
            double answer3 = number3 / 12.5;
            Console.WriteLine("The number " + num3 + " divided by 12.50 is " + answer3.ToString());

            Console.WriteLine();
            Console.WriteLine("please enter a number below:");
            string num4 = Console.ReadLine();
            double number4 = Convert.ToDouble(num4);
            bool answer4 = number4 >50;
            Console.WriteLine("Is the number " + num4 + " greater than 50? " + answer4.ToString());

            Console.WriteLine();
            Console.WriteLine("please enter a number below:");
            string num5 = Console.ReadLine();
            int number5 = Convert.ToInt32(num5);
            int answer5 = number5 % 7;
            Console.WriteLine("The remainder of " + num5 + " divided 7 is " + answer5.ToString());

            Console.ReadLine();

        }
    }
}
