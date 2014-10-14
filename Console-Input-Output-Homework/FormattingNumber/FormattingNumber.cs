using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class FormattingNumber
{
    static void Main(string[] args)
    {
        Console.Write("Enter number 1:");
        int numberA = int.Parse(Console.ReadLine());
        Console.Write("Enter number 2:");

        float numberB = float.Parse(Console.ReadLine());
        Console.Write("Enter number 3:");

        float numberC = float.Parse(Console.ReadLine());
        
        Console.WriteLine("|{0,-10:X}|{1}|{2,10:F2}|{3,-10:F3}|",numberA,Convert.ToString(numberA, 2).PadLeft(10,'0'),numberB,numberC);

    }
}

