using System;

namespace BankApp.App.Bank
{
    public class Customer
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string CustomerEmail { get; set; }
        public string FullName => firstName + " " + lastName;
        public string UserName { get; set; }
        public string PassWord { get; set; }
        public float balance { get; set; }

        public Customer(string first, string last, string email, string user, string passWord)
        {
            firstName = first;
            lastName = last;
            CustomerEmail = email;
            UserName = user;
            PassWord = passWord;
            //Console.ForegroundColor = ConsoleColor.Blue;
            //Console.WriteLine($"A Customer profile has been created for {FullName} with these informations \n{CustomerEmail} - {UserName}");
        }

    }
}