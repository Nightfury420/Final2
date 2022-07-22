using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Final2
{
    internal class Program
    {
        private static ArrayList m1 = new ArrayList();
        private static int x = 0;
        private static int y = 0;
        static void Main(string[] args)
        {
            Reprint();
        }

        private static void Reprint()
        {
            Console.CursorVisible = true;
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
        again:
            Console.Clear();
            Console.Write("ban muong nhap bao nhieu so: ");
            int n = int.Parse(Console.ReadLine());

            if (n < 5 || n > 10)
            {
                Console.WriteLine("Xin loi, ban chi duoc nhap tu 5 den 10 thoi");
                Thread.Sleep(2000);
                goto again;
            }

            m1.Clear();
            for (int i = 0; i < n; i++)
            {
                Console.Write("Nhap vao so {0} cua day so cua ban: ", i);
                int t = int.Parse(Console.ReadLine());
                m1.Add(t);
            }

            for (int i = 3; i >= 0; i--)
            {
                Console.SetCursorPosition(x, y + (n + 1));
                Console.WriteLine("Screen will clear in {0}", i);
                Thread.Sleep(1000);
            }
        }

    }
}
