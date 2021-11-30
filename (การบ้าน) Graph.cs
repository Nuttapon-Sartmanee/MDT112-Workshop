using System;

namespace TEST
{
    class Program
    {
        static void Main()
        {
            Console.Write("Total of City: ");
            int TotalCity = int.Parse(Console.ReadLine());
            int[,] Graph = new int[TotalCity, TotalCity];

            for (int i = 1; i <= TotalCity; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (i != j) 
                    {
                        Graph[i - 1, j - 1] = int.Parse(Console.ReadLine());
                    }
                }
            }

            Console.WriteLine("Show Graph");
            Console.WriteLine("");

            for (int i = 1; i <= TotalCity; i++)
            {
                for (int j = 1; j <= TotalCity; j++)
                {
                    Console.Write(Graph[i - 1 , j - 1]);
                    Console.Write(" ");
                }
                Console.WriteLine("");
            }

            Console.ReadKey();
        }
    }
}