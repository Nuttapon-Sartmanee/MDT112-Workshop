using System;

namespace makeflowchart
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int x = a;
            int y = b;

            while (x != y)
            {
                if (x < y)
                {
                    x = x + a;
                }
                else
                {
                    y = y + b;
                }
            }
            Console.WriteLine(x);
            Console.ReadKey();
        }
    }
}
