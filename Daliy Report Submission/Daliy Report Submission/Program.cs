using System;

namespace Daliy_Report_Submission
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Pitman Training");
            Console.WriteLine("Student Daliy Report");

            Console.WriteLine("Please answer the following questions as instructed.");

            Console.WriteLine("What Course are you in?");
            string course = Console.ReadLine();

            Console.WriteLine("What page number?");
            string Page = Console.ReadLine();
            int PageNum = Convert.ToInt32(Page);

            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\"");
            string HelpNeeded = Console.ReadLine();
            bool NeedsHelp = Convert.ToBoolean(HelpNeeded);

            Console.WriteLine("Were there any positive experinces you'd like to share? Please provide specifics");
            string Posexp = Console.ReadLine();

            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
            string feedback = Console.ReadLine();

            Console.WriteLine("How many hours did you study today?");
            string hours = Console.ReadLine();
            int HoursStudy = Convert.ToInt32(hours);

            Console.WriteLine("Thanks you for your responses. \nAn Instructor will respond shortly. \nHave a great day!");
            Console.ReadLine();
        }
    }
}
