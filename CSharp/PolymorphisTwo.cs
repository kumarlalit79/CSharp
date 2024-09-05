using System;

// method overriding :- like parent class mai ek method hai , or wo hi same method child class mai bhi hai , to child class ka method parent class ke method ko override kar dega

namespace CSharp
{
    class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Animal is eating");
        }
    }
    class Dog : Animal
    {
        public void Eat()
        {
            Console.WriteLine("Dog is eating");
        }
        public static void main(string[] args)
        {
            Dog tommy = new Dog();
            tommy.Eat();
        }
    }

}

// do Eat method banaye hai , par dono alag alag value ko print kar rahe hai. so value child ki print hoga cuz Dog ne Animal ko override kar diya
// isme bhi kuch condition hoti hai :-
// 1 - saare method ka name same hona chahiye
// 2 - all method should be in different class
// 3 - method mai same number of parameter hone chahiye , same type of parameter , same sequence of parameter 
// 4 - there should be inheritance b/w classes