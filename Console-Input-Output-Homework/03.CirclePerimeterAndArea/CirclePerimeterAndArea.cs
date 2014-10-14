using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CirclePerimeterAndArea
{
    static void Main(string[] args)
    {
        Console.Write("Enter radius: ");
        double radius = double.Parse(Console.ReadLine());
        double perimeter = 2 * Math.PI * radius;
        double area = Math.PI * (radius * radius);
        Console.WriteLine("Circle perimeter is: {0:F2}", perimeter);
        Console.WriteLine("Circle area is: {0:F2}", area);



    }
}

