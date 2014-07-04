using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Length
{
    class Program
    {
        static void Main(string[] args)
        {
            int year = 10;
            double interest_rate = 0.05;
            double value = 100;

            Console.WriteLine(string.Format("Start year 0, Asset:{0:C}\n", value));

            for (int i = 1; i <= year; i++)
            {
                //Compounding interest
                value = value * ( 1 + interest_rate);
                Console.WriteLine("Start of Year {0}, Asset {1:C}", i, value);
            }
        }
    }
}
