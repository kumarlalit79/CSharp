using System;


namespace CSharp
{

    class Bikes
    {
        private string model;
        private string color;
        private int price;

        private void PrintBikes()
        {
            Console.WriteLine(model);
            Console.WriteLine(color);
            Console.WriteLine(price);

            Console.ReadLine();
        }

        // maine in properties or bikes ko class mai create kiya h to mai inko sirf yahi access kar sakta hoon
    }
    class modifier
    {
        public static void main(string[] args)
        {
            Bikes obj = new Bikes();
            // yaha ham bike ki property ko nahi access kar paa rahe hai.
        }
    }
    
}
