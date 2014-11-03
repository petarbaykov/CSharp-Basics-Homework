using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitsInverter
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int step = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            for (int i = 0,k=1; i < numbers.Length; i++,k=k+step)
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());
                int pos = 8 - (k % 8);
                int mask = 1 << pos;
                numbers[i] = numbers[i] ^ mask;
         
            }
            for (int j = 0; j < numbers.Length; j++)
            {
                Console.WriteLine(numbers[j]);
            }
            
        }
    }
}
