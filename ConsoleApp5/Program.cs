using System;
namespace Oleg
{
    public class MainClass
    {
        static void Main()
        {
            Series12();
        }
        public static int Series1()
        {
            int sum = 0;
            int[] a = new int[10] { 15, 23, 3, 4, 5, 6, 7, 8, 9, 89 };
            for (int i = 0; i < 10; i++)
            {
                sum = sum + a[i];
            }
            return sum;
        }
        static void Series1a()
        {
            int sum = 0;
            int[] a = new int[10] { 15, 23, 3, 4, 5, 6, 7, 8, 9, 89 };
            foreach (int x in a)
            {
                sum = sum + x;
            }
            Console.WriteLine(sum);
        }

        public static int Series2()
        {
            int sum = 1;
            int[] a = new int[10] { 2, 10, 3, 4, 5, 6, 7, 8, 9, 10 };
            for (int i = 0; i < 10; i++)
            {
                sum = sum * a[i];
            }
            return sum;
        }
        static void Series3()
        {
            int sum = 0;
            const int n = 10;
            int[] a = new int[n] { 15, 23, 3, 4, 5, 6, 7, 8, 9, 89 };
            for (int i = 0; i < n; i++)
            {
                sum = sum + a[i];
            }
            sum = sum / n;
            Console.WriteLine(sum);
        }
        static void Series4()
        {
            const int n = 5;
            int sum1 = 1;
            int sum = 0;
            int[] a = new int[n] { 2, 10, 3, 4, 5 };
            for (int i = 0; i < 10; i++)
            {
                sum1 = sum1 * a[i];
                sum = sum + a[i];

            }
            Console.WriteLine(sum1);
            Console.WriteLine(sum);
        }
        static void Series5()
        {
            const int n = 3;
            double[] a = new double[n] { 3.2, 4.5, 6.7 };
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine((int)a[i]);
                sum = sum + (int)a[i];
            }
            Console.WriteLine(sum);

        }

        static void Series6()
        {
            const int n = 3;
            double[] a = new double[n] { 3.2, 4.5, 6.7 };
            double s = 1;
            for (int i = 0; i < n; i++)
            {
                a[i] = a[i] - (int)a[i];
                Console.WriteLine(a[i]);
                s *= a[i];
            }
            Console.WriteLine(s);
        }

        static void Series7()
        {
            const int n = 3;
            double[] a = new double[n] { 3.2, 4.5, 6.7 };
            double s = 0;
            for (int i = 0; i < n; i++)
            {
                a[i] = Convert.ToInt32(a[i]);
                Console.WriteLine(a[i]);
                s += a[i];
            }
            Console.WriteLine(s);
        }

        static void Series8()
        {
            const int n = 3;
            int[] a = new int[n] { 16, 23, 3 };
            int s = 0;
            for (int i = 0; i < n; i++)
            {
                if (a[i] % 2 == 0)
                {
                    Console.WriteLine(a[i]);
                    s++;
                }
            }

            Console.WriteLine(s);
        }

        static void Series9()
        {
            const int n = 3;
            int[] a = new int[n] { 4, 7, 13 };
            int s = 0;
            for (int i = 0; i < n; i++)
            {
                if (a[i] % 2 == 1)
                {
                    Console.WriteLine(i + 1);
                    s++;
                }
            }
            Console.WriteLine(s);
        }

        static void Series10()
        {
            const int n = 3;
            int[] a = new int[n] { 1, -2, -6 };
            bool b = false;
            foreach (int x in a)
            {
                if (x % 2 == 0)
                {
                    b = true;
                    break;
                }
            }
            switch (b)
            {
                case true:
                    Console.WriteLine("TRUE");
                    break;
                case false:
                    Console.WriteLine("FALSE");
                    break;
            }
        }

        static void Series11()
        {
            int k = 10;
            const int n = 3;
            int[] a = new int[n] { 7, 12, 15 };
            foreach (int x in a)
            {
                if (k > x)
                {
                    Console.WriteLine("TRUE");
                    Environment.Exit(0);
                }
            }
            Console.WriteLine("FALSE");
        }

        static void Series12()
        {
            const int n = 3;
            int s = 0;
            int[] a = new int[n] { 1, 4, 8 };
            for (int i = 0; i < n; i++)
            {
                s++;
                if (a[i] == 0)
                {
                    break;
                }
            }
            Console.WriteLine(s);
        }


    }
}