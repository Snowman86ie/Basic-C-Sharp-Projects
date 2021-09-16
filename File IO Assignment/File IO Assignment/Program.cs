using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace File_IO_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number below:");
            int userNum = Convert.ToInt32(Console.ReadLine());
            using (StreamWriter file = new StreamWriter(@"C:\Users\liamc\Documents\Github\Basic-C-Sharp-Projects\File IO Assignment\log.txt", true))
            {
                file.WriteLine(userNum);
            }
            string data = File.ReadAllText(@"C:\Users\liamc\Documents\Github\Basic-C-Sharp-Projects\File IO Assignment\log.txt");
            Console.WriteLine("\n\nThe log shows " + data);
            Console.ReadLine();
        }
    }
}
