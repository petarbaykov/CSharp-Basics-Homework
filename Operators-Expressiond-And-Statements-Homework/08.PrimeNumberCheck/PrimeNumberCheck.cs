using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class PrimeNumberCheck
{
    static void Main()
    {
      
        Console.Write("Enter a number you want to check: ");
        int number = int.Parse(Console.ReadLine());
        if (number%2==0)
        {
            if(number==2||number==1)
                Console.WriteLine(true);
        }
        for (int i = 3; i < 100; i++)
        {
            if(number%i==0)
            {
                Console.WriteLine(false);
            }
        }

    }
}

