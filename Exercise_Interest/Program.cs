using System;

namespace Exercise_Interest
{
    class Program
    {
        static void Main(string[] args)
        {
            int year = 10;
            double interest_rate = 0.05;
            double value = 100;

            Console.WriteLine(string.Format("Start year 0, Asset:{0:C}\n", value));

            for (int i = 0; i <= year; i++)
            {
                //Compounding interest
                value = value * (1 + interest_rate);
                Console.WriteLine("End of Year {0:D} , Asset {1:C}", i, value);
            }
        }
    }
}
