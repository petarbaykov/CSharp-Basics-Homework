using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class SumOfNNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        double sum = 0;
        for (int i = 0; i <n; i++)
		{
            double numbers = double.Parse(Console.ReadLine());
            sum = sum + numbers;
		}
        Console.WriteLine("The sum of your numbers is: {0}", sum);

    }
}

