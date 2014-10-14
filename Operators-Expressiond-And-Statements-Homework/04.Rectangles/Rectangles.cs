using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write an expression that calculates rectangle’s perimeter and area by given width and height. 


class Rectangles
{
    static void Main()
    {
        Console.Write("Enter triangle width: ");
        double width = double.Parse(Console.ReadLine());
        Console.Write("Enter triangle height: ");
        double height = double.Parse(Console.ReadLine());
        double rectangleArea = (width * height);
        double rectanglePerimeter = (2*width)+(2*height);
        Console.WriteLine("Triangle perimeter is: {0}", rectanglePerimeter);
        Console.WriteLine("Triangle area is: {0}",rectangleArea);
       

    }
}

