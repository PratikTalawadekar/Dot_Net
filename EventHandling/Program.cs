using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHandling
{
    class Program
    {
        static void Main()
        {
            Class1 objCls1 = new Class1();
            objCls1.InvalidP1 += objCls1_InvalidP1;

            objCls1.P1 = 100000;

            Console.ReadLine();
        }

        static void objCls1_InvalidP1()
        {
            Console.WriteLine("Event Handling code called");
        }
    }

    //Step1 : Create the delegate class having the same signature as the event handling function

    public delegate void Del1();
        public class Class1
        {
        //Steps 2 : declare the event as an object of the delegate class
        public event Del1 InvalidP1; 
            
            private int p1;
            public int P1
            {
                get
                {
                    return p1;

                }
            set
            {
                if (value < 100)
                    p1 = value;
                else
                {
                    //Step 3 :- raise n event here - InvalidP1
                    InvalidP1();
                }

            }
            
        }

        
    }
    
}
