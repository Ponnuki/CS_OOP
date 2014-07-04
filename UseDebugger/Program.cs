using System;

namespace UseDebugger
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = 1;
            int end = 5;

            for (int i = start; i < end; i++)
            {
                Console.WriteLine("value: {0}", i);
            }
        }
    }
}
