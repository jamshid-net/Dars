namespace ConsoleApp4.OperatorOverloading
{
    internal class Triangle
    {
        private int A;

        public int a
        {
            get => A;
            private set => A = value;
        }
        private int B;

        public int b
        {
            get => B;
            private set => B = value;
        }


        private int C;

        public int c
        {
            get => C;
            private set => C = value;
        }

        //private int A, B, C;
        public Triangle()
        {

        }
        public Triangle(int a, int b, int c)
        {
            A = a;
            B = b;
            C = c;
        }

        public static Triangle operator -(Triangle t1)
        {
            t1.A -= 2;
            t1.B -= 2;
            t1.C -= 2;

            return t1;
        }

        public static Triangle operator -(Triangle t1, Triangle t2)
        {
            Triangle t = new()
            {
                A = t1.A - t2.A,//2
                B = t1.B - t2.B,//3
                C = t1.C - t2.C//5
            };
            return t;
        }
        public static bool operator <=(Triangle t1, Triangle t2)
        {
            return (t1.A <= t2.A) &&
                (t1.B <= t2.B) &&
                (t1.C <= t2.C);
        }
        public static bool operator >=(Triangle t1, Triangle t2)
        {
            return (t1.A >= t2.A) &&
                (t1.B >= t2.B) &&
                (t1.C >= t2.C);
        }

        public static Triangle operator ++(Triangle t1)
        {
            t1.A++;
            t1.B++;
            t1.C++;
            return t1;
        }
        public override string ToString()
        {
            return $"A->{A}, B->{B}, C->{C}";
        }

        public override bool Equals(object? obj)
        {
            return ((Triangle)obj).A == this.A && ((Triangle)obj).B == B;
           

        }


    }
}
