using System;

// ek method many behaviour

// Method Overloading :- same naam ke multiple objects
namespace CSharp
{
    class Programs
    {
        void Sum(int a , int b)
        {
            Console.WriteLine(a + b);
        }
        void Sum(float a , float b)
        {
            Console.WriteLine(a + b);
        }

        public static void main(string[] args)
        {
            Programs obj = new Programs();
            obj.Sum(10, 20); // yaha maine integer value daali hai isliye ye automatically int waala method le lega
            obj.Sum(10.2f, 20.1f);
            Console.ReadLine();
        }
    }
}

// inko karne ki bhi kuch conditions hoti hai
// 1 - yaha to dono methods ka type different alg ho
// 2 - yaha to dono mai parameter different different ho
// 3 - sequence ya to alag alg ho. like ek mai int a , int b or doosre mai int b , int a