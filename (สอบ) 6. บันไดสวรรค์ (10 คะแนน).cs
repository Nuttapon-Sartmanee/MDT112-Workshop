using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testtest
{
    class Program
    {
        static void Main(string[] args)
        {
            char symbol = char.Parse(Console.ReadLine());
            int Width = int.Parse(Console.ReadLine());
            int Height = int.Parse(Console.ReadLine());
            int Num = int.Parse(Console.ReadLine());

            for (int k = 1; k <= Num; k++)
            {
                for (int i = 1; i <= Width; i++)
                {
                    for (int j = 1; j <= Height; j++)
                    {
                        Console.Write(symbol);
                    }
                    Console.WriteLine();
                }
                Width += Width;
                Height += Height;
            }
            
            Console.ReadKey();
        }
    }
}
