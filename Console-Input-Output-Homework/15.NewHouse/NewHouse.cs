using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class NewHouse
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <=n; i+=2)
        {
            string asterics = new string('*', i);
            string dashes = new string('-', (n - i) / 2);
            Console.WriteLine("{0}{1}{0}",dashes,asterics);
            
        }
        for (int i = 0; i <=n; i++)
        {
            Console.WriteLine("|"+new string('*',(n-2))+"|");
        }
    }
}

