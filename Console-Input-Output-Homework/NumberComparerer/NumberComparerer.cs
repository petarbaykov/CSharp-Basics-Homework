using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class NumberComparerer
{
    static void Main(string[] args)
    {
        double firstNumber = double.Parse(Console.ReadLine());
        double secondNumber = double.Parse(Console.ReadLine());
        double greaterNumber = Math.Max(firstNumber, secondNumber);
        Console.WriteLine("The greater number is: {0}",greaterNumber);

    }
}

