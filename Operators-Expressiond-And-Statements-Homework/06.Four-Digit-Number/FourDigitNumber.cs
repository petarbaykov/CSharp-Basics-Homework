using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
//•	Calculates the sum of the digits (in our example 2+0+1+1 = 4).
//•	Prints on the console the number in reversed order: dcba (in our example 1102).
//•	Puts the last digit in the first position: dabc (in our example 1201).
//•	Exchanges the second and the third digits: acbd (in our example 2101).
//The number has always exactly 4 digits and cannot start with 0. 
       6789	          6987	              9786



class FourDigitNumber
{
    static void Main(string[] args)
    {
        Console.Write("Enter a four-digit number: ");
        int userNumber = int.Parse(Console.ReadLine());
        while(userNumber>9999&&userNumber<1000)
        {
            Console.WriteLine("Invalid!!! Your number should be exactly four digit and can't stat with 0.Please try again! ");
        }
        int fourthDigit = userNumber % 10;
        int thirdDigit = (userNumber / 10) % 10;
        int secondDigit = (userNumber / 100) % 10;
        int firstDigit = (userNumber / 1000) % 10;
       

        int sum = fourthDigit + thirdDigit + secondDigit + firstDigit;
        Console.WriteLine(sum);
        Console.WriteLine("Number reversed: {0}{1}{2}{3}",fourthDigit,thirdDigit,secondDigit,firstDigit);
        Console.WriteLine("Last digit in front: {0}{1}{2}{3}", fourthDigit,firstDigit,secondDigit, thirdDigit  );
        Console.WriteLine("Second and third digits exchanged: {0}{1}{2}{3}",  firstDigit, thirdDigit, secondDigit,fourthDigit);


    }
}
