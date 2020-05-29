using System;

namespace iBankaBaltija
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account("Yuri", 200);
            Console.WriteLine($"Client {account.Owner} has {account.Balance} rubles in account number {account.Number} created on {account.Created.ToString("dd/MM/yyyy")}");
            account.Created = new DateTime(2019,10,24);
            Console.WriteLine($"Client {account.Owner} has {account.Balance} rubles in account number {account.Number} created on {account.Created.ToString("dd/MM/yyyy")}");
        }
    }
}
