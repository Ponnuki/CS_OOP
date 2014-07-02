using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j;

            for (i = 2; i < 100; i++)
            {
                for (j = 2; j <= (i / j); j++)
                    if ((i % j) == 0) break; // if factor found, not prime
                if (j > (i / j))
                    Console.WriteLine("{0} is prime", i);
            }

            Console.WriteLine("Press any key to continue...");
            Console.Read();
        }
    }
}
