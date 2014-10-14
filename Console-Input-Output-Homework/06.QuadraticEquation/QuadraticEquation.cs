using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class QuadraticEquation
{
    static void Main()
    {
        Console.Write("Enter coefficient a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter coefficient b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter coefficient c: ");
        double c = double.Parse(Console.ReadLine());
        double diskriminant = (b * b) - (4 * (a * c));
        double x1 = (-b - (Math.Sqrt(diskriminant))) / (2 * a);
        double x2 = (-b + (Math.Sqrt(diskriminant))) /( 2 * a);
        if (diskriminant<0)
        {
            Console.WriteLine("no real roots");
        }
        else if (diskriminant==0)
        {
            
            Console.WriteLine("X1=X2={0}",x1);
        }
        else
        {
            Console.WriteLine("X1= {0}", x1);
            Console.WriteLine("X2= {0}", x2)

        }





    }
}

