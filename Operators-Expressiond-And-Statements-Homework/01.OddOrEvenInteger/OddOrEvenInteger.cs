using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write an expression that checks if given integer is odd or even. Examples:

class OddOrEvenInteger
{
    static void Main(string[] args)
    {
        int userNumber = int.Parse(Console.ReadLine());
        if(userNumber%2==0)
            Console.WriteLine("Your number is even");
        else
            Console.WriteLine("Your number is odd");
    }
}

