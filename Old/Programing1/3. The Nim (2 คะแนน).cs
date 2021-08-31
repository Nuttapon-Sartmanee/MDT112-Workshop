using System;

namespace _3_the_nim
{
    class Program
    {
        static void Main(string[] args)
        {
            int inbox1 = int.Parse(Console.ReadLine());
            int inbox2 = int.Parse(Console.ReadLine());
            int inbox3 = int.Parse(Console.ReadLine());
             
            while (inbox1 + inbox2 + inbox3 != 0) 
            {
                //A Turn
                int A = int.Parse(Console.ReadLine());
                int nA = int.Parse(Console.ReadLine());
                if (A == 1)
                {
                    inbox1 = inbox1 - nA;
                }
                else if (A == 2)
                {
                    inbox2 = inbox2 - nA;
                }
                else if (A == 3)
                {
                    inbox3 = inbox3 - nA;
                }
                if (inbox1 + inbox2 + inbox3 == 0)
                {
                    Console.WriteLine("B");
                    break;
                }

                //B Turn
                int B = int.Parse(Console.ReadLine());
                int nB = int.Parse(Console.ReadLine());
                if (B == 1)
                {
                    inbox1 = inbox1 - nB;
                }
                else if (B == 2)
                {
                    inbox2 = inbox2 - nB;
                }
                else if (B == 3)
                {
                    inbox3 = inbox3 - nB;
                }
                if (inbox1 + inbox2 + inbox3 == 0)
                {
                    Console.WriteLine("A");
                }
            }
            Console.ReadKey();
        }
    }
}
