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
            string factorial_statement;

            Console.Write("Please enter a number:");
            flag = int.TryParse(Console.ReadLine(), out number);

            if (!flag)
            {
                factorial_statement = "Not a number";
            }
            else
            {
                factorial_statement = string.Format("{0}! =", number);
                for (int i = number; i >= 1; i--)
                {
                    factorialValue *= i;
                    factorial_statement = i == number ? string.Format("{0} {1}", factorial_statement, i) : string.Format("{0} * {1}", factorial_statement, i);
                }

                Console.WriteLine(factorial_statement);
                Console.WriteLine(string.Format("{0}! = {1}", number, factorialValue));
            }           
        }
    }
}
