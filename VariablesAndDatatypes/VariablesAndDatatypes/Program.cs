using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesAndDatatypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("What is your name?");
            //string yourName = Console.ReadLine();
            //Console.WriteLine("Your name is: " + yourName);
            //Console.ReadLine();

            //Console.WriteLine("What is your favourite number?");
            //string favouriteNumber = Console.ReadLine();
            //int favnum = Convert.ToInt32(favouriteNumber);
            //int Total = favnum + 5;
            //Console.WriteLine("Your favourite number plus 5 is: " + Total);
            //Console.ReadLine();

            bool isStudying = false;
            byte hoursworked = 42;
            sbyte currenttemp = -23;
            char RandomLetter = 'Y';
            char questionMark = '\u2103';
            decimal moneyinbank = 100.5m;
            double heightinCM = 205.343;
            float secondsLeft = 2.63f;
            short tempMars = -341;

            int currentAge = 30;
            string yearsOld = currentAge.ToString();

            string StudyStatus = Convert.ToString(isStudying);

            Console.WriteLine(StudyStatus);
            Console.ReadLine();
        }
    }
}
