﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Which of the following values can be assigned to a variable of type float and which to a variable of type double: 34.567839023, 12.345, 8923.1234857, 3456.091? Write a program to assign the numbers in variables and print them to ensure no precision is lost.

class FloatOrDouble
{
    static void Main(string[] args)
    {
        double firstNumber = 34.567839023;
        float secondNumber = 12.345f;
        double thirdNumber = 8923.1234857;
        float fourthNumber = 3456.091f;
        Console.WriteLine(firstNumber + "\r\n" + secondNumber + "\r\n" + thirdNumber + "\r\n"+fourthNumber);

    }
}

