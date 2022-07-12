using System;

namespace BankApp.App.Bank
{
    public class Account : IAccount
    {
        Customer customer = new Customer("John", "Doe", "john@doe.com", "johnny", "password");
        public Account()
        {
        }

        public void CreateCustomer()
        {

        }

        public void MakeDeposit(float amount, DateTime date, string note)
        {
            customer.balance += amount;
            Console.WriteLine(customer.balance);

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine($"\n{note}");
            Console.WriteLine($"${amount} was credited from the account {customer.UserName} owned by {customer.firstName + "" + customer.lastName}, current balance is ${customer.balance}");
        }

        public void MakeWithdrawal(float amount, DateTime date, string note)
        {
            customer.balance -= amount;
            Console.WriteLine(customer.balance);

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine($"\n{note}");
            Console.WriteLine($"${amount} was debited from the account {customer.UserName} owned by {customer.firstName + "" + customer.lastName}, current balance is ${customer.balance}");
        }

        public float GetBalance()
        {
            return customer.balance;
        }
    }
}