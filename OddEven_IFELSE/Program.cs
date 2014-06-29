using System;

namespace OddEven_IFELSE
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

            if (value % 2 == 1)
            {
                output = "Number is odd";
            }
            else
            {
                output = "Number is even";
            }

            Console.WriteLine(output);
        }
    }
}
