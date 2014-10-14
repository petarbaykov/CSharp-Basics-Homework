using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Trapezoid
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter side a: ");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter side b: ");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter side h: ");
        int h = int.Parse(Console.ReadLine());
        double trapezoidArea = (0.5 * (a + b)) * h;
        Console.WriteLine("Trapezoid area is: {0}", trapezoidArea);


    }
}

