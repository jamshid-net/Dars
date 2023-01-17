using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.OperatorOverloading
{
    class Complex
    {
        private int x;
        private int y;
        public Complex()
        {
            Console.WriteLine("Complex");
        }
        public Complex(int i, int j)
        {
            x = i;
            y = j;
        }
        public void ShowXY()
        {
            Console.WriteLine("{0} {1}", x, y);
        }
        public static Complex operator -(Complex c)
        {
            Complex temp = new Complex(5,10);
            temp.x = 2*c.x;
            temp.y = 2*c.y;
            return temp;
        }
        public static Complex operator +(Complex c)
        {
            Complex temp = new Complex();
            temp.x = c.x/2;
            temp.y = c.y/2;
            return temp;
        }
    }
}
