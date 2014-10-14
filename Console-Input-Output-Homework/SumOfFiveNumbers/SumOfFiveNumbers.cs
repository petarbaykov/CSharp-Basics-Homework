using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class SumOfFiveNumbers
{
    static void Main(string[] args)
    {
        Console.Write("Enter your numbers: ");
        string [] userNumbers = Console.ReadLine().Split(' ');
       
        double firstNumber = double.Parse(userNumbers[0]);
        double secondNumber = double.Parse(userNumbers[1]);
        double thirdNumber = double.Parse(userNumbers[2]);
        double fourthNumber = double.Parse(userNumbers[3]);
        double fifthNumber = double.Parse(userNumbers[4]);
        double sum = firstNumber + secondNumber + thirdNumber + fourthNumber + fifthNumber;
        Console.WriteLine("The sum of your numbers is: {0}",sum);

        

    }
}

