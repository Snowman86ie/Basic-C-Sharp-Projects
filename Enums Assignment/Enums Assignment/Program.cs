using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the current day:");
            string userDay = Console.ReadLine();

            DaysofWeek day1;
            
            
            try
            {
                if (Enum.TryParse<DaysofWeek>(userDay, true, out day1))
                {
                    Console.WriteLine("The current day is: "+ day1);
                }
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Please enter an actual day of the week");
            }

            Console.ReadLine();
        }

        public enum DaysofWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
    }
}
