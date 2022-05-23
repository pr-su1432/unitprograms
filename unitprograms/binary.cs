using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unitprograms
{
    internal class binary
    {
        public void Convert()
        {
            static int binaryToDecimal(string input)
            {
                int result = 0;
                for (int i = input.Length; i > 0; i--)
                    if (input.Substring(i - 1, 1) == "1")
                        result += (int)Math.Pow(2, (input.Length - i));
                Console.WriteLine(result);
                return result;
            }
        }
    }



}

