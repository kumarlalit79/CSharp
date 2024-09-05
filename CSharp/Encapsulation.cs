using System;

namespace Learning
{
    class Account
    {
        // 1 -  mai nahi chata ki is account balance ki information ko koi or class access kar sake. to maine ise private bana diya
        private int accountBalance = 1000;

        // 2 -  par agar mai is accountBalance ki property ko access karna chahta hoon kisi doosri class mai to mai getter or setter ka use karta hoon

        public void SetBalance(int amt)
        {
            if(amt < 0) // to hamne yaha pe encapsulate kar diya ki yaha pe -ve value nahi aa sakti
            {
                Console.WriteLine("cannot give -ve ");
            }
            else
            {

                accountBalance = amt; // ab is Setter method ki help se jo bhi amount aayega wo maine accountBalance(encapsulated) ko assign karwa diya. mai main funcn mai setbalance method ki help se use get kar sakta hoon
            }
        }

        // get :- jo mera account balance h wo mughe get karna hai
        public void GetBalance()
        {
            Console.WriteLine("Your balance is :" + accountBalance);
        }
    }

    class Encapsulation
    {
        public static void main(string[] args)
        {
            Account account = new Account();
            account.SetBalance(5000);
            account.GetBalance();
            Console.ReadLine();
        }
    }
}


