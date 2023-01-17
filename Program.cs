using ConsoleApp4.OperatorOverloading;

namespace ConsoleApp4
{
    internal class Program
    {
        
        static void Main()
        {
            //Complex c1 = new Complex(10, 20);
            ////c1.ShowXY(); // displays 10 & 20  
            //Complex c2 = new Complex(0, 10);
            ////c2.ShowXY(); // displays 0 & 0  
            //c2 = +c1;
            //c2.ShowXY(); // diapls -10 & -20 

            int g = 17;
            g.Equals(new Triangle()) ;
            Console.WriteLine(g.ToString());
            Triangle t = new(3, 4, 5);
            t = -t;
            Console.WriteLine(t.ToString());
            Triangle t1 = new(3, 5, 8);
            Triangle t2 = t1 - t;
            Console.WriteLine(t2.ToString());
            bool b = t2 <= t;
            Console.WriteLine("t2 <= t:" + b);
            b = t2 >= t;
            Console.WriteLine("t2 >= t:" + b);
            t = t++;
            Console.WriteLine(t.ToString());
            Console.WriteLine();

            Coords c = new(3, 5);
            c.PrintX();
            

        }
        public partial class Coords
        {
            
            private int x;
            private int y;

            public Coords(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
            public void PrintX()
            {
                Console.WriteLine("x", x);
            }
            public static partial void OnNameChanged();
    }

    public partial class Coords 
    {
        public void PrintCoords()
        {
            Console.WriteLine("Coords: {0},{1}", x, y);
        }
        public static partial void OnNameChanged()
        {
            Console.WriteLine("sfgdfgdf");
        }
    }
    public class A
    {
        public void PrintA()
        {
            Console.WriteLine("A");
        }
    }
    public class B
    {

    }
}
}