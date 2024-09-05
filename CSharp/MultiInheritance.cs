using System;


namespace CSharp
{
    class Car2
    {
        public string model;
        public string color;
        public int price;

        public void printCarInformation2()
        {
            Console.WriteLine("Model : " + model);
            Console.WriteLine("Color : " + color);
            Console.WriteLine("Price : " + price);
        }
    }

    class Ferarri : Car2
    {
        int speed;

        public void printSpeed()
        {
            Console.WriteLine("Speed : " + speed);
        }
    }
    class Rolls2 : Ferarri
    {
        float Milage2;

        void PrintMilage2()
        {
            Console.WriteLine("Milage : " + Milage2);
        }

        public static void main(string[] args)
        {
            Rolls myCar2 = new Rolls();
            myCar2.model = "top model";
            myCar2.color = "red";
            myCar2.price = 100000000;
            

            myCar2.printCarInformation();
            
        }
    }
}
