using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddEven_Ternary
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag;
            int value;
            string output;

            Console.WriteLine("Please enter a number...");
            Console.Write("Value:");

            flag = int.TryParse(Console.ReadLine(), out value);

            if (flag == false)
            {
                output = "Not a number";
            }

            output = (value % 2 == 0) ? "Number is even" : "Number is odd";

            Console.WriteLine(output);
        }
    }
}
