using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class ModifyBitAtGivenPosition
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter number: ");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter p index: ");
        int p = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter value of bit: ");
        int v = int.Parse(Console.ReadLine());
        int mask = 1 << p;
        int nAndMask = number & mask;
        int bit = nAndMask >> p;
        
    }
}

