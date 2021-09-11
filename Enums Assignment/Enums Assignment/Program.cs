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
            Enter:
            Console.WriteLine("Please enter the current day:");
            string userDay = Console.ReadLine();

            DaysofWeek day1;
            
            
            try
            {
                if (Enum.TryParse<DaysofWeek>(userDay, true, out day1))
                {
                    
                    Console.WriteLine("The current day is: "+ day1);
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Please enter an actual day of the week");
                goto Enter;
            }
            finally
            {
                Console.WriteLine("Program finished");
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
