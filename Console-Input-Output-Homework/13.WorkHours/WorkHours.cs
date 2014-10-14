using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class WorkHours
{
    static void Main(string[] args)
    {
        int hoursToFinish = int.Parse(Console.ReadLine());
        int daysToFinish = int.Parse(Console.ReadLine());
        double productivity = int.Parse(Console.ReadLine());
        double hoursSheWork = (daysToFinish-(daysToFinish * 0.1))*12;
        double efficientWorkHours = hoursSheWork * (productivity / 100);
       
        if (efficientWorkHours>=hoursToFinish)
        {
            int diff = (int)efficientWorkHours -( hoursToFinish) ;
            Console.WriteLine("Yes");
            Console.WriteLine(diff);
        }
        else
        {
            int diff = (int)((hoursToFinish)-(int)efficientWorkHours);            
            Console.WriteLine("No");
            Console.WriteLine(-diff);
            
        }
    }
}

