using System;
using BankApp.App.Bank;
using BankApp.App.Services;

namespace BankApp.App.Directing
{
    public class Operations
    {
        public Operations()
        {
        }

        public static void Deposit()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("\nAttempting to credit a customer's account");
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("Type in the amount that you want to credit into this account");
            float amount = GetNumber();

            Account account = new Account();
            account.MakeDeposit(amount, DateTime.Now, $"Crediting {amount} into the account");
        }

        public static void Withdraw()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("\nAttempting to debit a customer's account");
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("Type in the amount that you want to credit into this account");
            float amount = GetNumber();

            Account account = new Account();
            account.MakeWithdrawal(amount, DateTime.Now, $"Debiting {amount} from this account");
        }

        public static void Balance()
        {
            Account account = new Account();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine($"\nYour current balance is: ${account.GetBalance()}");
        }

        public static string GetString() => Console.ReadLine();

        public static float GetNumber()
        {
            float.TryParse(GetString(), out var theAmount);
            return theAmount;
        }

    }
}