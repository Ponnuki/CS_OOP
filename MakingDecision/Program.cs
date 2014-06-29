using System;

namespace MakingDecision
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start...");
            if (5 < 10)
            {
                // Logic true: if statement block
                Console.WriteLine("Run if statement block");
            }

            Console.WriteLine("Completed...");

            Console.WriteLine("Press any key to continue...");
            Console.Read();
        }
    }
}
