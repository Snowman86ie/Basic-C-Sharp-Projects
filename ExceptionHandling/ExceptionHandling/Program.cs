using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            List<int> numbers = new List<int> { 1, 4, 8, 12, 16, 20 };
            Console.WriteLine("Please enter a number:");
            int userNumber = Convert.ToInt32(Console.ReadLine());

            foreach (int num in numbers)
                {
                    int answer = (num / userNumber);
                    Console.WriteLine(answer);
                }
            
        }
        catch(FormatException ex)
        {
            Console.WriteLine("Please select a whole number to divide by:");
        }
        catch(DivideByZeroException ex)
        {
            Console.WriteLine("Please dont divide by zero");
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            Console.ReadLine();
        }
        Console.WriteLine("Program continues");
        Console.ReadLine();


    }
}

