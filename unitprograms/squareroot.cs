using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unitprograms
{
    internal class squareroot
    {
        public void square()
        {
            string x;
            double sqrtofx;

            Console.Write("Enter a number: ");
            x = Console.ReadLine();

            sqrtofx = Math.Sqrt(Convert.ToInt32(x));

            Console.WriteLine("\nSqrt({0}): {1}", x, sqrtofx);

            Console.ReadKey();
        }
    }
}
