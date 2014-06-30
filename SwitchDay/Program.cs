using System;

namespace SwitchDay
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag;
            int day;
            string output = string.Empty;

            Console.WriteLine("Please enter a number...");
            Console.Write("Value:");

            flag = int.TryParse(Console.ReadLine(), out day);

            if (flag == false)
            {
                output = "Not a number";
            }

            switch (day)
            {
                case 1:
                    output = "Monday";
                    break;
                case 2:
                    output = "Tuesday";
                    break;
                case 3:
                    output = "Wednesday";
                    break;
                case 4:
                    output = "Thursday";
                    break;
                case 5:
                    output = "Friday";
                    break;
                case 6:
                    output = "Saturday";
                    break;
                case 7:
                    output = "Sunday";
                    break;
                default:
                    output = "Error";
                    break;
            }

            if (day <= 7 && day > 0 )
            {
                Console.WriteLine(string.Format("Today is {0}", output));
            }
            else
            {
                Console.WriteLine("number must be within 1-7");
            }
        }
    }
}
