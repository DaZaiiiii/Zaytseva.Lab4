using System;

namespace Zaytseva.Lab4.Exercise__1
{
    class Program
    {
        static void Main(string[] args)
        {
            // a. 20x + 3
            // b. 2y

            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());

            int a = ResInt(x, y);
            Console.WriteLine(a);

            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            double d = ResDouble(b, c);

            Console.WriteLine(d);

            char e = char.Parse(Console.ReadLine());
            char f = char.Parse(Console.ReadLine());
            int g = ResChar(e, f);
            Console.WriteLine(g);
        }
        // int
        static int Result1(int x)
        {
            int h = 20 * x + 3;
            return h;
        }
        static int Result2(int y)
        {
            int h = 2 * y;
            return h;
        }
        static int ResInt(int x, int y)
        {
            int i = Result1(x);
            int j = Result2(y);
            int h = Math.Max(i, j);
            return h;
        }
        // double

        static double Res1(double b)
        {
            double h = 20 * b + 3;
            return h;
        }
        static double Res2(double t)
        {
            double h = 2 * t;
            return h;
        }
        static double ResDouble(double d, double w)
        {
            double i = Res1(d);
            double j = Res2(w);
            double m = Math.Max(i, j);
            return m;
        }

        // char

        static int Res1(char z)
        {
            int w = 20 * z + 3;
            return w;
        }
        static int Res2(char r)
        {
            int s = 2 * r;
            return s;
        }

        static int ResChar(char z, char r)
        {
            int q = Res1(z);
            int v = Res2(r);
            int l = Math.Max(q, v);
            return l;
        }

    }
}
