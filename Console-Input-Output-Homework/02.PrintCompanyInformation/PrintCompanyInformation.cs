using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class PrintCompanyInformation
{
    static void Main(string[] args)
    {

        Console.Write("Enter company name: ");
        string companyName = Console.ReadLine();
        Console.Write("Enter company adress: ");
        string companyAdress = Console.ReadLine();
        Console.Write("Enter phone number: ");
        string phoneNumber = Console.ReadLine();
        Console.Write("Enter fax number: ");
        string faxNumber = Console.ReadLine();
        Console.Write("Enter web site: ");
        string webSite = Console.ReadLine();
        Console.Write("Enter manager first name: ");
        string managerFirstName = Console.ReadLine();
        Console.Write("Enter manager last name: ");
        string managerLastName = Console.ReadLine();
        Console.Write("Enter manager age: ");
        string managerAge = Console.ReadLine();
        Console.Write("Enter manager phone: ");
        string managerPhone = Console.ReadLine();
        Console.WriteLine(companyName); 
            Console.WriteLine("Adress:{0}", companyAdress);
        Console.WriteLine("Tel.{0}", phoneNumber);
        Console.WriteLine("Fax:{0} ", faxNumber); 
        Console.WriteLine("Web site:{0} ", webSite);
        Console.WriteLine("Manager: {0} {1}(age:{2}, tel.{3})",managerFirstName,managerLastName,managerAge,managerPhone);
    }
}

