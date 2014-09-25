using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//A marketing company wants to keep record of its employees. Each record would have the following characteristics:
//•	First name
//•	Last name
//•	Age (0...100)
//•	Gender (m or f)
//•	Personal ID number (e.g. 8306112507)
//•	Unique employee number (27560000…27569999)
//Declare the variables needed to keep the information for a single employee using appropriate primitive data types. Use descriptive names. Print the data at the console.


class EmployeeData
{
    static void Main(string[] args)
    {
        string firstName = "Nedqlko";
        string lastName = "Nedqlkov";
        byte age = 25;
        char gender = 'm';
        long personalIDnumber = 8306112507;
        long employeeNumber = 27560001;
        Console.WriteLine("First name:"+firstName);
        Console.WriteLine("Last name:" + lastName);
        Console.WriteLine("Age:" + age);
        Console.WriteLine("Personal ID number:" + personalIDnumber);
        Console.WriteLine("Employee number:" + employeeNumber);




    }
}

