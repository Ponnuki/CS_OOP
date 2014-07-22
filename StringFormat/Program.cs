using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFormat
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = "First Name";
            var b = "Last Name";

            Console.WriteLine("{0} {1}");
            Console.WriteLine(string.Format("{0} {1}", a, b));

            Console.WriteLine("{0}");
            Console.WriteLine(string.Format("{0}", a, b));
        }
    }
}
