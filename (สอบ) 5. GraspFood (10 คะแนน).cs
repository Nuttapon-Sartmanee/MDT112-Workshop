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
            int DayOfWeek = int.Parse(Console.ReadLine());
            int TimeOfDay = int.Parse(Console.ReadLine());
            string Menu = "";

            int BreakfastSet = 5;
            int WeekendSet = 2;
            int Coffee = 3;

            do
            {
                Menu = Console.ReadLine();
                switch (Menu)
                {
                    case "Breakfast Set":
                        if (TimeOfDay <= 11)
                        {
                            if (BreakfastSet > 0)
                            {
                                BreakfastSet--;
                            }
                            else
                            {
                                Console.WriteLine("Sorry your order is out of stock");
                            }
                            break;
                        }
                        else 
                        {
                            Console.WriteLine("Sorry your order is not available");
                        }
                        break;
                    
                    case "Weekend Set":
                        if (DayOfWeek > 5)
                        {
                            if (WeekendSet > 0)
                            {
                                WeekendSet--;
                            }
                            else
                            {
                                Console.WriteLine("Sorry your order is out of stock");
                            }
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Sorry your order is not available");
                        }
                        break;
                        
                    
                    case "Coffee":
                        if (Coffee > 0)
                        {
                            Coffee--;
                        }
                        else
                        {
                            Console.WriteLine("Sorry your order is out of stock");
                        }
                        break;
                    
                    default:
                        Console.WriteLine("Please enter a valid menu");
                        break;
                }
            } while (Menu != "End");
        }
    }
}
