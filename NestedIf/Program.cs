using System;

namespace NestedIf
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

            if (value > 10)
            {
                Console.WriteLine(string.Format("Number {0} is more than 10", value));

                if (value > 100)
                {
                    Console.WriteLine(string.Format("Number {0} is more than 100", value));
                }
            }
        }
    }
}
