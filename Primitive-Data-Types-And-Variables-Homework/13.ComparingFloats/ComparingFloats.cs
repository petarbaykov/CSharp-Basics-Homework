using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001. Note that we cannot directly compare two floating-point numbers a and b by a==b because of the nature of the floating-point arithmetic. Therefore, we assume two numbers are equal if they are more closely to each other than a fixed constant eps. 

class ComparingFloats
{
    static void Main(string[] args)
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        bool checker=Math.Abs(a-b)<0.000001;
        if ( checker==true)       
        {
            Console.WriteLine("Equal:"+true);
        }
        else
        {
            Console.WriteLine("Equal:"+false);
        }
    }
}

