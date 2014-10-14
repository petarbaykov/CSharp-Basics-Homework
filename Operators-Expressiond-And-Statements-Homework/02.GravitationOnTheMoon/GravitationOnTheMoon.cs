using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//The gravitational field of the Moon is approximately 17% of that on the Earth. Write a program that calculates the weight of a man on the moon by a given 
//weight on the Earth.




class GravitationOnTheMoon
{
    static void Main(string[] args)
    {
        Console.Write("Enter a weight: ");
        double userWeight = double.Parse(Console.ReadLine());
        double weightOnTheMoon = userWeight * (0.17);      
        Console.WriteLine("Your weight on the Moon will be: {0}",weightOnTheMoon);
    }
}

