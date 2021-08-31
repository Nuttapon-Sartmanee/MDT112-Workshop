using System;

namespace _1_Pascal
{
    class Program
    {
        static void Calculating(int numfloor)
        {
            int i , j;
            for (i = 1; i <= numfloor; i++)
            {
                for (j = 0; j <= i; j++)
                {
                    Console.Write(Cal_Factorial(i) / (Cal_Factorial(i - j) * (Cal_Factorial(j))));
                    Console.Write(" ");
                }
                Console.WriteLine("");
            }
        }
        static int Cal_Factorial(int num)
        {
            int ans = 1;
            for (int i = 1 ; i <= num ; i++)
            {
                ans *= i;
            }
            return ans;
        }
        static void Main(string[] args)
        {
            int numFloor;
            do
            {
                numFloor = int.Parse(Console.ReadLine());
                if (numFloor >= 0)
                {
                    Console.WriteLine("1");
                    Calculating(numFloor);
                }
                else
                {
                    Console.WriteLine("Invalid Pascal’s triangle row number.");
                }
            } while (numFloor < 0);
            
            Console.ReadKey();    
        }
    }
}
