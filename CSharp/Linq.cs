using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    class Linq
    {
        static void Main(string[] args)
        {
            int[] age = {10, 20, 30, 40, 50 , 60, 70, 80, 90, 100};

            // LINQ Select Query
            var a = from i in age select i;
            foreach (var item in a)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            // LINQ Select Query with Condition
            var b = from i in age where i > 50 select i;
            foreach (var item in b)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            // LINQ Sorting (ORDER BY) 
            var c = from i in age where i > 50 orderby i descending select i ;
            foreach (var item in c)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            string[] colors = { "red", "green", "blue", "pink", "white", "orange", "yellow" };
            var d = from i in colors where i.Contains("i") select i; // jin mai i aata hai sirf wo hi show honge.
            foreach (var item in d)
            {
                Console.WriteLine(item);
            }
        }
    }
}
