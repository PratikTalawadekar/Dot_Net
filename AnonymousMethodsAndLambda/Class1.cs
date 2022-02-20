using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousMethodsAndLambda
{
    class Class1
    {
        static void Main()
        {

            Func<int, int> o1 = a => a * 2;
            Func<int, int> o2 = (a) => a * 2;

            Console.WriteLine(o1(15));
            
            Func<int, int, int> o3 = (a, b) => a + b;
            Console.WriteLine(o3(1015, 20));

            Console.ReadLine();
        }
        //Not needed below part
        public static int GetDouble(int a)
        {
            return a * 2;
        }

        public int Add(int a, int b)
        {
            return a + b;
        }

    }
}
