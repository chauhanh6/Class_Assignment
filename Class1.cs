using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Assignment
{
    internal class Account
    {
        private int accountNumber;
        private decimal balance;
        private string ownerName;

        public Account(int accountNumber, decimal balance, string owner)
        {
            this.accountNumber = accountNumber;
            this.balance = balance;
            this.ownerName = owner;
        }
        public int AccountNumber
        {
            get
            {
                return accountNumber;
            }
        }

       public string OwnerName
        {
            get
            {
                return ownerName;
            }
        }

        public void Deposit(decimal amount)
        {
            balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            balance -= amount;
        }

        public decimal GetBalance()
        {
            return balance;

        }
        public decimal GetDecimal() => balance;
    }

}


