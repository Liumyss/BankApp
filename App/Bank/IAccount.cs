using System;

namespace BankApp.App.Bank
{
    public interface IAccount
    {

        public void CreateCustomer();

        public void MakeDeposit(float amount, DateTime date, string note);

        public void MakeWithdrawal(float amount, DateTime date, string note);

    }
}