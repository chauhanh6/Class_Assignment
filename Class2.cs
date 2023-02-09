using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Assignment
{
    internal class AccountManager
    { 
    private List<Account> accounts;

    public AccountManager()
    {
        accounts = new List<Account>();
    }

    public void AddAccount(Account account)
    {
        accounts.Add(account);
    }

    public void DisplayAccounts()
    {
        foreach (Account account in accounts)
        {
            Console.WriteLine("Account Number: " + account.AccountNumber);
            Console.WriteLine("Owner: " + account.OwnerName);
            Console.WriteLine("Balance: " + account.GetBalance);
            Console.WriteLine();
        }
    }
