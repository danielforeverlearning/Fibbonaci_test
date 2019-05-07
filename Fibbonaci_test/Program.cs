using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibbonaci_test
{
    class Program
    {
        
        //fib(94) and beyond is wrong because of overflow of ulong.....

        static ulong  Order_of_N_Fib(ulong  xx)
        {
            ulong AA = 0;
            ulong BB = 0;
            ulong sum = 0;
            for (ulong ii=0;  ii <= xx; ii++)
            {
                if (ii == 0)
                    BB = 0;
                else if (ii == 1)
                    AA = 1;
                else
                {
                    sum = AA + BB;
                    //AA is the n-1, BB is the n-2
                    BB = AA;
                    AA = sum;
                    Console.WriteLine("Fib of {0} = {1}", ii, sum);
                }
            }
            return sum;
        }
        static void Main(string[] args)
        {
            ulong  result = Order_of_N_Fib(100);

            Console.WriteLine("DONE");
        }
    }
}
