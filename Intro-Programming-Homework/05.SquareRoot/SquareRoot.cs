﻿using System;


//Create a console application that calculates and prints the square root of the number 12345. Find in Internet “how to calculate square root in C#”.


class SquareRoot
{
    static void Main(string[] args)
    {
        int number = 12345;
        double result=Math.Sqrt(number);
        Console.WriteLine(result);
    }
}

