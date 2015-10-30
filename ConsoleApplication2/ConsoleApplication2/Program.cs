//22.10.2015
//Вариант
//БПИ 153
//Трухачев Валентин Вадимович

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Контрольная_работа_2
{
    class Program
    {
        static int[] CreateArray(int N, int min, int max)
        {
            Random ran = new Random();
            int[] CreateArra = new int[N];
            for (int i = 0; i < N; i++)
            {
                CreateArra[i] = ran.Next(min, max);
            }
            return CreateArra;
        }
        static int PrintArray(int[] mass)
        {
            int ln = mass.Length;
            for (int i = 0; i < ln; i++)
            {
                if (i % 10 == 0) Console.WriteLine();
                Console.Write(mass[i]); Console.Write(" ");

            }
            return 1;
        }

        static void Main(string[] args)
        {
            int N, min, max;
            do
            {
                do Console.WriteLine("Vvedite chislo");
                while (!int.TryParse(Console.ReadLine(), out N));
                do Console.WriteLine("Vvedite chislo");
                while (!int.TryParse(Console.ReadLine(), out min));
                do Console.WriteLine("Vvedite chislo");
                while (!int.TryParse(Console.ReadLine(), out max));
                int[] mass = CreateArray(N, min, max);
                N = PrintArray(mass);

            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);

        }
    }
}
