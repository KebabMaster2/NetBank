using System;
using System.Collections.Generic;

namespace iBankaBaltija
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Account> accounts = new List<Account>(); 
            accounts.Add(new Account("Yuri", 200));
            Console.WriteLine($"Client {accounts[0].Owner} has {accounts[0].Balance} rubles in account number {accounts[0].Number} created on {accounts[0].Created.ToString("dd/MM/yyyy")}");
            accounts.Add(new Account("I.P", 150));
            Console.WriteLine($"Client {accounts[1].Owner} has {accounts[1].Balance} rubles in account number {accounts[1].Number} created on {accounts[1].Created.ToString("dd/MM/yyyy")}");
            Console.WriteLine(accounts[0].Balance);
        }

    }
}
