using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassandMethods_Assignment1
{
    class Math
    {
        public static int Addition(int number)
        {
            int answer = number + number;
            return answer;
        }
        public static decimal Addition(decimal number)
        {
            decimal answer = number * number;
            return answer;
        }
        public static string Addition(string number)
        {
            int temp = Convert.ToInt32(number);
            string answer2 = (temp -4).ToString();
            return answer2;
        }
    }
}
