using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class PointInsideOfCircleAndOutsideOfTriangle
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter X: " );
        double x = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter Y: ");
        double y = double.Parse(Console.ReadLine());
        bool result = (x * x) + (y * y) <= 1.5*1.5;
        if(result==true)
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }

    }
}

