using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please enter your age:");
                int age = Convert.ToInt32(Console.ReadLine());
                DateTime year = DateTime.Now;
                if (age <= 0)
                {
                    throw new NotSupportedException();
                }
                
                int yearBorn = (year.Year - age);

                Console.WriteLine("You were born in the year {0}", yearBorn);
                Console.ReadLine();
            }
            catch (NotSupportedException)
            {
                Console.WriteLine("Please enter a positive number for age.");
                Console.ReadLine();
                return;
            }
            catch (FormatException)
            {
                Console.WriteLine("A string is not accepted.");
                Console.ReadLine();
                return;
            }
            catch (Exception)
            {
                Console.WriteLine("An error has occured, please contact your system admin!");
                Console.ReadLine();
                return;
            }
            
        }
    }
}
