using System;

namespace Parabola
{
    class Program
    {
        static void Main(string[] args)
        {
            string mode = Console.ReadLine();
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            //y = Math.Pow(x - 1, 2);
            //x = Math.Sqrt(y) + 1;

            switch (mode)
            {
                case "time":
                    if (x > 0)
                    {
                        Console.WriteLine("{0},{1}", x , Math.Pow(x - 1, 2));
                    }
                    else 
                                Console.WriteLine("Invalid mouse position");
                    break;
                
                case "price":
                    if (x > 0)
                    {
                        Console.WriteLine("{0},{1}", Math.Sqrt(y) + 1, y);
                    }
                    
                    else
                        Console.WriteLine("Invalid mouse position");
                    break;
                
                default:
                        Console.WriteLine("Invalid mode");
                    break;
            }

            Console.ReadKey();

        }
    }
}
