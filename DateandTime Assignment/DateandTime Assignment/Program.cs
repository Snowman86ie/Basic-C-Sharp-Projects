using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DateandTime_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime time = DateTime.Now;
            Console.WriteLine("Current Date and time is: {0}" , time);
            Console.WriteLine("Please enter a number below:");
            
            int data = Convert.ToInt32(Console.ReadLine());
            
            DateTime newTime = time.AddHours(data);
            Console.WriteLine("Time in {0} hours is: {1}",data, newTime);

            Console.ReadLine();
        }
    }
}
