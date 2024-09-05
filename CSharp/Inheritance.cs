using System;

// parent child relationship build karne ke kaam aata hai , child class parent class ki property ko inherit(acquire ) kar sakti hai

namespace CSharp
{
    class Car
    {
        public string model;
        public string color;
        public int price;

        public void printCarInformation()
        {
            Console.WriteLine("Model : " + model);
            Console.WriteLine("Color : " + color);
            Console.WriteLine("Price : " + price);
        }
    }

    class Rolls : Car
    {
        float Milage;

        void PrintMilage()
        {
            Console.WriteLine("Milage : " + Milage );
        }

        public static void main(string[] args)
        {
            Rolls myCar = new Rolls();
            //ab mughe milage , modak , color and price sb kuch print karwaana h , to mai milage to print karwa sakta hoon , cuz se same class ke andar hai , par mai baaki nahi print karwa skata. inko print karwaane ke liye mughe Rolls class ke sath car class ko inherit karwaana padega

            // assigning values with the help of obj
            myCar.model = "RR";
            myCar.color = "grey";
            myCar.price = 600000000;
            myCar.Milage = 22.5f;

            // calling function to print assigned values
            myCar.printCarInformation();
            myCar.PrintMilage();
            Console.ReadLine();
        }
    }
}

// maine car class mai properties ko public rakha h tabhi mai inhe yaha pe access kar pa raha hoon. Protected mai bhi access kar skte , private mai nahi kar pate