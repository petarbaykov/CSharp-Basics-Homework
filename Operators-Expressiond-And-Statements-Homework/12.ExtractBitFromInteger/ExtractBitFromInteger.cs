using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ExtractBitFromInteger
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter number: ");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter index p: ");
        int p = int.Parse(Console.ReadLine());
        int mask = 1 << p;
        int nAndMask = number & mask;
        int bit = nAndMask >> p;
        Console.WriteLine("Your {0} is {1}", p,bit);
    }
}

