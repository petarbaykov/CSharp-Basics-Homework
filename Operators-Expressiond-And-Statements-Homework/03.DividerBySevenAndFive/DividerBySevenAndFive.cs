using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a Boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 in the same time. Examples:




class DividerBySevenAndfive
{
    static void Main(string[] args)
    {
        Console.Write("Enter number: ");
        int userNumber = int.Parse(Console.ReadLine());
        bool checker = (userNumber % 5 == 0) && (userNumber % 7 == 0);
        Console.WriteLine(checker);
    }
}

