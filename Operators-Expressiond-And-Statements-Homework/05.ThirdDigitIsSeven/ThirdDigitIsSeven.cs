using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write an expression that checks for given integer if its third digit from right-to-left is 7. 


class ThirdDigitIsSeven
{
    static void Main(string[] args)
    {
        Console.Write("Enter number: ");
        int userNumber = int.Parse(Console.ReadLine());
        int thirdDigit=userNumber/100;
        bool result = Math.Abs(thirdDigit) % 10==7;
        Console.WriteLine(result);
    }
}

