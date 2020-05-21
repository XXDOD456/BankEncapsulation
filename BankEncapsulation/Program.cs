using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace BankEncapsulation
{
    class Program
    {
        static void Main(string[] args)
        { var bank = new BankAccount();
            Console.WriteLine($"Hello, how much would you like to deposit? Your current balance is {bank}");
            var amountToDeposit = double.Parse(Console.ReadLine());
            bank.Deposit(amountToDeposit);
            Console.WriteLine($"Your current balance is {bank.GetBalance()}");

            var info = new PersonalInformation();
            string number;
            long result;
           
            do
            {
                Console.WriteLine("What is your area code and telephone number?");
                Console.WriteLine("Using the formatting 000000000");

            }
        }
        
    }
}
