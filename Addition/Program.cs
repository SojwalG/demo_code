using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Addition
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;

            Console.Write("Enter Value for A:");
            a=Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Value for B:");
            b=Convert.ToInt32(Console.ReadLine());
            c = a + b;
            Console.WriteLine("Addition is:"+ c);
        }
    }
}
