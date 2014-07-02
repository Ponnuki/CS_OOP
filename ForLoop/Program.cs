using System;

namespace ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("For #1");
            for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("For #2");
            for (int i = 10 - 1; i >= 0; i--)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("For #3");
            for (int i = 0; i < 20; i+=2)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("For #4");
            for (int i = 10 - 1; i >= 0; i-=2)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("For #5");
            for (int i = 0; i < (20 / 2) ; i+=2)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
        }
    }
}
