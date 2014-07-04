using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag;
            int number;
            double factorialValue = 1;
            string output;

            Console.Write("Please enter a number:");
            flag = int.TryParse(Console.ReadLine(), out number);

            if (!flag)
            {
                output = "Not a number";
            }
            else
            {
                for (int i = 1; i <= number; i++)
                {
                    factorialValue *= i;
                }

                output = string.Format("Factorial of {0} = {1}", number, factorialValue);
            }

            Console.WriteLine(output);
            
        }
    }
}
