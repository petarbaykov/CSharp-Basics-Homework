using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
class FibonacciNumbers
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        if(n==0)
        {
            Console.WriteLine(0);
        }
        else if (n == 1)
        {
            Console.WriteLine(0);
        }
        
        else
        {
            BigInteger first = 0;
            BigInteger second = 1;
            Console.Write(first+" ");
            Console.Write(second + " ");
            BigInteger third=0;
            for (int i = 2; i <n; i++)
            {
                third = first + second;
                Console.Write(third+" ");
                first = second;
                second = third;
            }
        }
    }
}
