using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class SumOfElements
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        string[] numbers = input.Split(' ');
        int max = int.MinValue;
        int sum=0;
        for (int i=0;  i < numbers.Length; i++)
        {
            int element = int.Parse(numbers[i]);
            sum = sum + element;
            if(element>max)
            {
                max = element;
            }
        }
        if(sum==2*max)
        {
            Console.WriteLine("Yes, sum={0}",max);
        }
        else
        {
            int diff = Math.Abs(sum - 2 * max);
            Console.WriteLine("No, diff={0}",diff);
        }






    }


}

