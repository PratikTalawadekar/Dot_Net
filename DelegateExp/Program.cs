using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateExp
{
    public delegate void NewDelegate(int a, int b);
    class MathOper
    {
        public void Add(int a, int b)
        {
            Console.WriteLine("Add Result: {0}", a + b);
        }
        public void Sub(int x , int y)
        {
            Console.WriteLine("Substract Result: {0}", x - y);
        }
        public void Multiply(int f, int g)
        {
            Console.WriteLine("Multiply Result: {0}", f *g);
        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ya aha Delegate Ka Example");
            MathOper m = new MathOper();
            NewDelegate ndl = m.Add;
            ndl += m.Sub;
            ndl += m.Multiply;
            ndl(10, 90);


            Console.ReadLine();
        }
    }
}
