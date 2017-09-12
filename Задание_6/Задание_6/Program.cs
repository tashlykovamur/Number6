using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Задание_6
{
    class Program
    {
        static int Calc(double[] arr, double M, int i)
        {
            arr[i] = arr[i - 2] / arr[i - 1] + Math.Abs(arr[i - 3]);

            if (i == arr.Length - 1)
                return i + 1;

            if (arr[i] > M)
                return i + 1;

            return Calc(arr, M, i + 1);
        }

        static void Main(string[] args)
        {
            double a1, a2, a3, M;
            int N;

            Console.WriteLine("Введите a1");
            a1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите a2");
            a2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите a3");
            a3 = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите M");
            M = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите N");
            N = int.Parse(Console.ReadLine());

            double[] arr = new double[N];
            arr[0] = a1;
            arr[1] = a2;
            arr[2] = a3;

            int n = Calc(arr, M, 3);

            Console.Write("Причина останова: ");

            if (n == N)
                Console.WriteLine(" последовательность содержит N элементов");
            else
                Console.WriteLine(" выполнилось условие a[k] > M");

            for (int i = 0; i < n; i++)
            {
                Console.Write("{0:0.##} ", arr[i]);
            }

            Console.WriteLine();

            Console.ReadLine();
        }
    }
}