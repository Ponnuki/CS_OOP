using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeapYear
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag;
            int year;
            string output;

            Console.WriteLine("Please enter a year...");
            Console.Write("Value:");

            flag = int.TryParse(Console.ReadLine(), out year);

            if (flag == false)
            {
                output = "Not a number";
            }

            if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
            {
                output = string.Format("{0} is leap year", year);
            }
            else
            {
                output = string.Format("{0} is not leap year", year);
            }

            Console.WriteLine(output);
        }
    }
}
