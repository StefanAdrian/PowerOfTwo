using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerOfTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 15;

            while (number > 0)
            {
                int temp = HighestPowerOfTwo(number);
                Console.Write("{0} + ", temp);
                number = number - temp;
            }
            Console.WriteLine();
        }

        static int HighestPowerOfTwo(int number)
        {
            int result = 1;
            while (number > 1)
            {
                number = number / 2;
                result = result * 2;
            }
            return result;
        }
    }
}
