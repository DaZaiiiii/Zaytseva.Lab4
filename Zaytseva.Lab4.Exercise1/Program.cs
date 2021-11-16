using System;

namespace Zaytseva.Lab4.Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            string type;
            Console.WriteLine("Выберите тип данных: int, double, char для а = 20Х + 3 и b = 2У");
            type = Console.ReadLine();

            switch (type)
            {
                case "int":
                    Console.WriteLine("Введите х: ");
                    int xi = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите y: ");
                    int yi = Convert.ToInt32(Console.ReadLine());
                    int a = Form1(xi, yi);
                    Console.WriteLine(a);

                    break;

                case "double":
                    Console.WriteLine("Введите х: ");
                    double xd = double.Parse(Console.ReadLine());
                    Console.WriteLine("Введите y: ");
                    double yd = double.Parse(Console.ReadLine());
                    double b = Form2(xd, yd);
                    Console.WriteLine(b);

                    break;
            
                case "char":
                    Console.WriteLine("Введите х: ");
                    char xc = Convert.ToChar(Console.ReadLine());
                    Console.WriteLine("Введите y: ");
                    char yc = char.Parse(Console.ReadLine());
                    char c = Form3(xc, yc);
                    Console.WriteLine(c);

                    break;
            }

            static int Form1(int x, int y)
            {
                int x1 = Math.Abs(20 * x + 3);
                int y1 = Math.Abs(2 * y);

                if (x1 > y1)
                {
                    return x1;
                }

                else
                {
                    return y1;
                }

            }

            static double Form2(double x, double y)
            {
                double x1 = Math.Abs(20 * x + 3);
                double y1 = Math.Abs(2 * y);

                if (x1 > y1)
                {
                    return x1;
                }

                else
                {
                    return y1;
                }

            }


            static char Form3(char x, char y)
            {
                char x1 = (char)Math.Abs((20 * x) + 3);
                char y1 = (char)Math.Abs(2 * y);

                if (x1 > y1)
                {
                    return x1;
                }

                else
                {
                    return y1;
                }

            }
        }
    }

}
