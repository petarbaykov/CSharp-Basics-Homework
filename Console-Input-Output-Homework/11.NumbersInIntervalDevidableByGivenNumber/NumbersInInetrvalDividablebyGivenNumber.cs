using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class NumbersInIntervalDividablebyGivenNumber
{
    static void Main()
    {
        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());
        int p=0;
        for (int i = firstNumber; i <=secondNumber; i++)
        {
            if (i % 5 == 0)
            {
                p++;
            }
                
        }
        Console.WriteLine(p);
    }
}

