using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousMethodsAndLambda
{
    class Program
    {
        static void Main1(string[] args)
        {
            Action o1 = delegate ()
            {
                Console.WriteLine("Anon method called");
            };
            o1();
            Console.ReadLine();
        }

        static void Main()
        {
            Func<int, int, int> o2 = delegate (int a, int b)
           {
               return a + b;
           };
            Console.WriteLine(o2(10, 20));
            Console.ReadLine();

        }

       /* static void Display()
        {
            Console.WriteLine("Display Called");
        }*/
    }
}
