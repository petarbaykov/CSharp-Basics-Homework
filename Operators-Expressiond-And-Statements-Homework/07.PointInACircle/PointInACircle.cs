using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write an expression that checks if given point (x,  y) is inside a circle K({0, 0}, 2).

class PointInACircle
{
    static void Main(string[] args)
    {
        Console.Write("Enter X: ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("Enter Y: ");
        double y = double.Parse(Console.ReadLine());
        bool checker = (x * x) + (y * y) <= 2*2;
        Console.WriteLine(checker);
    }
}

