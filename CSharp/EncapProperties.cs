using System;

// encapsulation karne ka wo poorana tareeka hai , ab hamare pass get and set properties majood hai

namespace CSharp
{
    class Account
    {
        private int accountBalance = 1000;

        public int Balance
        {
            set
            {
                if(value < 0)
                {
                    Console.WriteLine("Cant pass -ve value");
                }
                else
                    accountBalance = value;
            }
            get
            {
                return accountBalance;
            }
        }
        
    }

    class Encapsulation
    {
        public static void main(string[] args)
        {
            Account account = new Account();
            account.Balance = 2000;
            Console.WriteLine("Your account balance : " + account.Balance);

            Console.ReadLine();
        }
    }
}
