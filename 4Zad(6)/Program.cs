using System;

namespace _4Zad_6_
{
    class Program
    {
        static int[][] Input()
        {
            Console.WriteLine("введите размер массива");
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            int[][] a = new int[n][];
            for (int i = 0; i < n; ++i)
            {
                a[i] = new int[n];
                for (int j = 0; j < n; ++j)
                {
                    Console.Write("a[{0},{1}]= ", i, j);
                    a[i][j] = int.Parse(Console.ReadLine());
                }
            }
            return a;
        }
        static void print(int[][] a)
        {
            for (int i = 0; i < a.Length; i++, Console.WriteLine())
                for (int j = 0; j < a[i].Length; j++)
                    Console.Write("{0,5}", a[i][j]);
        }
        static void print2(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
                Console.WriteLine("{0,5}", a[i]);
        }

        static int Pol(int[] a)
        {
            int count = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (1 <= a[i])
                    count++;
            }
            return count;
        }
        static void Main()
        {
            
            int[][] mass = Input();
            Console.WriteLine("Исходный массив:");
            print(mass);
            int[] rez = new int[mass.Length];
            for (int i = 0; i < mass.Length; ++i)
                rez[i] = Pol(mass[i]);
            Console.WriteLine("Новый массив");
            print2(rez);
        }
    }
}
