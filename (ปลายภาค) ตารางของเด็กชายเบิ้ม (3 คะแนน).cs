using System;

namespace Test
{
    class Program
    {
        static void FirstTable(ref int[,] table)
        {
            for (int i = 0; i <= table.GetLength(0) - 1; i++)
            {
                for (int j = 0; j <= table.GetLength(1) - 1; j++)
                {
                    int input = int.Parse(Console.ReadLine());
                    table[i, j] = input;
                }
            }
        }
        static void ShowTable(int[,] table)
        {
            for (int i = 0; i <= table.GetLength(0) - 1; i++)
            {
                for (int j = 0; j <= table.GetLength(1) - 1; j++)
                {
                    Console.Write(table[i, j]);
                }
                Console.WriteLine();
            }
        }
        static void AddNum(ref int[,] table, ref int Addnum)
        {
            Addnum = int.Parse(Console.ReadLine());
            for (int i = 0; i <= table.GetLength(0) - 1; i++)
            {
                for (int j = 0; j <= table.GetLength(1) - 1; j++)
                {
                    if (table[i, j] == 0)
                    {
                        table[i, j] = Addnum;
                    }
                    else
                    {
                    }
                }
            }
        }
        static void CheckNum(int[,] table, int Addnum)
        {
            int output = 0;
            for (int i = 0; i <= table.GetLength(0) - 1; i++)
            {
                for (int j = 0; j <= table.GetLength(1) - 1; j++)
                {
                    if (Addnum == table[i, j])
                    {
                        output++;
                    }
                    else
                    {
                    }
                }
            }
            if (output > 1)
            {
                Console.WriteLine("The number is available");
            }
            else
            {
                ShowTable(table);
            }
        }
        static void Main(string[] args)
        {
            int[,] table = new int[3, 3];
            int Addnum = 0;
            FirstTable(ref table);
            ShowTable(table);
            AddNum(ref table, ref Addnum);
            CheckNum(table, Addnum);

            Console.ReadKey();
        }
    }
} 


