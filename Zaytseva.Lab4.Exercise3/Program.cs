using System;

namespace Zaytseva.Lab4.Exercise3
{
    class Program
    {
            static double Method1(double k)
            {
                double a = (-1 * k + 2) / 3;
                return a;
            }

            static double Method2(double k)
            {

                if (k == 1)
                {
                    return Method1(k);
                }
                else
                {
                    return Method1(k) + Method2(k - 1);
                }

            }
        static void Main(string[] args)
        {
                Console.WriteLine("Введите n:");
            int n = Convert.ToInt32(Console.ReadLine());
                double a = Method2(n);

            Console.WriteLine("Ответ:" + a);
        }
    }
}
