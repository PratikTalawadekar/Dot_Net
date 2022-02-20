using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyConDemo
{
    class Program
    {
        /*static void Main(string[] args)
        {

        }
*/
        class CopyConDemo
        {
            int x;
            public CopyConDemo(int i)
            {
                x = i;
            }

            public void Display()
            {
                Console.WriteLine("value of x is:" + x);
             
            }

            static void Main()
            {
                CopyConDemo cd1 = new CopyConDemo(10);
                    cd1.Display();
                Console.ReadLine();
            }
        }
    }
}
