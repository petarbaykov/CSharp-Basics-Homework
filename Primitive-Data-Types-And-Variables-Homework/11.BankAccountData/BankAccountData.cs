using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//A bank account has a holder name (first name, middle name and last name), available amount of money (balance), bank name, IBAN, 3 credit card numbers associated with the account. Declare the variables needed to keep the information for a single bank account using the appropriate data types and descriptive names.


class BankAccountData
{
    static void Main(string[] args)
    {
        string firstName = "Nedqlko";
        string middleName = "Nedqlkov";
        string lastName = "Nedqlkov";
        decimal availableAmountOfMoney = 1564.5644654654m;
        string bankName = "UBB";
        string IBAN = "49548654345";
        string firstCreditCardNumber = "54646534654";
        string secondCreditCardNumber = "5464645624";
        string thirdCreditCardNumber = "52131596454";


        Console.WriteLine("First name:" + firstName);
        Console.WriteLine("Middle name:" + middleName);
        Console.WriteLine("Last name:" + lastName);
        Console.WriteLine("Available amount of money:"+availableAmountOfMoney);
        Console.WriteLine("Bank Name:"+bankName);
        Console.WriteLine("IBAN:" + IBAN);
        Console.WriteLine("First credit card number:"+firstCreditCardNumber);
        Console.WriteLine("Second credit card number:" + secondCreditCardNumber);
        Console.WriteLine("Third credit card number:" + thirdCreditCardNumber);


       

       

    }
}

