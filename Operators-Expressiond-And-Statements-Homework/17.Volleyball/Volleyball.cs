using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Volleyball
{
    static void Main(string[] args)
    {
        string additionPlays = Console.ReadLine();
        int holidays = int.Parse(Console.ReadLine());
        int weekendsInHometown = int.Parse(Console.ReadLine());
        int totalWeekends= 48;

        double normalWeekends = (totalWeekends - weekendsInHometown) * 3 / 4;
        double totalPlays = normalWeekends + weekendsInHometown + (holidays * 2 / 3);
        if (additionPlays == "leap")
        {
            totalPlays = (0.15 * totalPlays)+totalPlays;
        }
        Console.WriteLine((int)totalPlays);
    }
}

