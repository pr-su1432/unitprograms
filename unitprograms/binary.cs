using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unitprograms
{
    internal class binary
    {
        public void num()
        {
            int binary2Decimal(string bin)
            {
                int res;
                char[] cArr = bin.ToCharArray();
                Array.Reverse(cArr); // Reverse binary string
                List<int> iArr = new List<int>();
                for (int i = bin.Length - 1; i > -1; i--) // Get the bits
                    iArr.Add(Int16.Parse(cArr[i].ToString()) * (int)Math.Pow(2, i)); // Calculate each bits and add to an array
                res = iArr.ToArray().Sum(); // Calculate all the numbers and add to the final result
                Console.WriteLine(res);
                return res;
            }
        }
         
    }
}
