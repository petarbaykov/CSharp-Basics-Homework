using System;

//Write a program to print the numbers 1, 101 and 1001, each at a separate line. Name the program correctly. You should submit in your homework the Visual Studio project holding the source code of the PrintNumbers program.


class PrintNumbers
{
    static void Main(string[] args)
    {
        int firstNumber = 1;
        int secondNumber = 101;
        int thirdNumber = 1001;
        Console.WriteLine(firstNumber);
        Console.WriteLine(secondNumber);
        Console.WriteLine(thirdNumber);


        //Two another ways to print he numbers
        //First:
        //string firstNum = 1;
        //string secondNum = 101;
        //string thirdNum = 1001;
        //Console.WriteLine(firstNum);
        //Console.WriteLine(secondNum);
        //Console.WriteLine(thirdNum);
        //Second:
        //Console.WriteLine("1");
        //Console.WriteLine("101");
        //Console.WriteLine("1001");
    }
}

