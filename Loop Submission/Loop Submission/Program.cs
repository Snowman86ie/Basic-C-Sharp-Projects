using System;


namespace Loop_Submission
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please pick a number between 1 and 10:");
            int number = Convert.ToInt32(Console.ReadLine());
            bool guess = false;

            while(!guess)
                switch(number)
                {
                    case 6:
                        Console.WriteLine("Congrats you guessed right!");
                        guess = true;
                        break;
                    default:
                        Console.WriteLine("Your guess is incorrect, Please try again!");
                        Console.WriteLine("Please pick a number between 1 and 10:");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                }

            Console.WriteLine();
            Console.WriteLine("Game 2");
            Console.WriteLine("Please pick a number between 1 and 100:");
            int number2 = Convert.ToInt32(Console.ReadLine());
            bool guess2 = false;
            do
            {
                switch (number2)
                {
                    case 44:
                        Console.WriteLine("Congrats you guessed right!");
                        guess2 = true;
                        break;
                    default:
                        Console.WriteLine("Your guess is incorrect, Please try again!");
                        Console.WriteLine("Please pick a number between 1 and 100:");
                        number2 = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            while (!guess2);

            Console.ReadLine();
        }
    }
}
