using System;

//Write a program to read your birthday from the console and print how old you are now and how old you will be after 10 years.

class AgeAfterTenYears
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your birthday in format (dd.mm.yyyy):");
        DateTime userBirthaday = DateTime.Parse(Console.ReadLine());
        long userAge = DateTime.Today.Subtract(userBirthaday).Ticks;
        Console.WriteLine("Your age is {0}:", new DateTime(userAge).Year - 1);
        Console.WriteLine("After 10 years you will be {0} years old", new DateTime(userAge).AddYears(10).Year - 1);
    }
}

