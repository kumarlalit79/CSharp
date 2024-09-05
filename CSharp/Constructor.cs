using System;

// constructor :- ye bhi ek type ka method hota hai , pr ye ek different type ka hota hai. 
// ye bhi ek method hota hai pr iska or class ka naam hamesha same hota hai.
// constructor ki koi return type nahi hoti. to ye koi value return bhi nahi karta.
// constructor tab execute hota hai jab ham uske object ko create karte hai. hame main method mai constructor ko call karane ki jarrort nahi padti.
// jese maine yaha pe constructor create kiya , then maine uska obj banaya , to use kehte hai user defined constructor. agr mai bina constructor create kiya uska obj bana du to automatically ek constructor create ho jayega, jise kehte hai defalt constructor.

namespace CSharp
{
    class Program
    {
        public Program() // clss and constructor ka naam same h but koi isme return type nahi hai
        {
            Console.WriteLine("Hello I am constructor");
        }
        public static void main(string[] args)
        {
            Program obj = new Program(); // constructor ko call karane ki jarrort nahi padti.
            Console.ReadLine();
        }
    }
    
    
}
