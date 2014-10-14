using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SumOfThreeNumbers
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter first number");
        double firstNumber = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number");
        double secondNumber = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter third number");       
        double thirdNumber = double.Parse(Console.ReadLine());
        double sum = firstNumber + secondNumber + thirdNumber;
        Console.WriteLine("The sum of yours numbers is: {0}",sum);

    }
}

