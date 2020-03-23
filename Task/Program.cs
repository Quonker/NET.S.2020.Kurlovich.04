using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("$$$$$$$$$$\n\n\n");
            double d = -0.0;
            Console.WriteLine(d);
            Console.WriteLine(d.ConvertDoubleToBinaryString());

            d = 0;
            Console.WriteLine(d.ConvertDoubleToBinaryString());

            Console.WriteLine(-0.0);
            Console.WriteLine("\n\n\n");

           
        }
    }
}
