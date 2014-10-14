using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ExtractBitThree
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter number: ");
        int number = int.Parse(Console.ReadLine());
        int p = 3;
        int mask = 1 << p;
        int nAndMask = number & mask;
        int bit = nAndMask >> p;
        Console.WriteLine("Third bit is: {0}", bit);
    }
}

