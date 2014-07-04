using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedWhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;

            while (i < 100)
            {
                int j = 2;

                while (j <= (i / j))
                {
                    if ((i % j) == 0)
                    {
                        break;
                    }
                    j++;
                }

                if (j > (i / j))
                {
                    Console.WriteLine("{0} is prime number", i);
                }

                i++;
            }

            Console.Write("Press any key to continue...");
            Console.Read();
        }
    }
}
