using System;

namespace Price_Quote_Application_Submission
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Package Express! \nPlease follow the instructions below:");
            Console.WriteLine();
            Console.WriteLine("Please enter the package weight(kgs):");
            int weight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            if (weight >50)
            {
                Console.WriteLine("Package is too heavy to be shipped via Package Express. \nHave a good day.");
                goto End;
            }
            else
            {
                Console.WriteLine("Please enter package width(cm):");
                int width = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter package height(cm):");
                int height = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter package lenght(cm):");
                int lenght = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                int package = width + height + lenght;
                if (package > 50)
                {
                    Console.WriteLine("Package is too big to be shipped via Package Express.");
                    goto End;
                }
                decimal shipping = Convert.ToDecimal(((height*width*lenght)*weight)/ 100);
                Console.WriteLine();
                Console.WriteLine("The price for shipping this package is: " + shipping +" euros.");
                Console.WriteLine("Thank you for using Package Express!");
            }

        End:
            Console.ReadLine();
        }
    }
}
