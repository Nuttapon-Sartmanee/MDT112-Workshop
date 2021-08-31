using System;

namespace Test
{
    class Program
    {
        struct Item
        {
            public string name;
            public string type;
        }

        static void InputItem(Item[] ArrItem)
        {
            for (int i = 0; i < ArrItem.Length; i++)
            {
                ArrItem[i].name = Console.ReadLine();
                ArrItem[i].type = Console.ReadLine();
            }
        }

        static void FindItem(Item[] ArrItem)
        {
            string Input;
            bool IsLoop = true;

            while (IsLoop == true)
            {
                Input = Console.ReadLine();

                if (Input == "ShowAll")
                {
                    for (int i = 0; i < ArrItem.Length; i++)
                    {
                        Console.WriteLine(ArrItem[i].name);
                        Console.WriteLine(ArrItem[i].type);
                        Console.WriteLine();
                    }
                }
                else
                {
                    for (int i = 0; i < ArrItem.Length; i++)
                    {
                        if (Input == ArrItem[i].type)
                        {
                            Console.WriteLine(ArrItem[i].name);
                            Console.WriteLine();
                        }
                    }

                }
            }
        }

        static void Main()
        {
            int NumItem = int.Parse(Console.ReadLine());
            Item[] ArrItem = new Item[NumItem];

            InputItem(ArrItem);
            FindItem(ArrItem);

            Console.WriteLine("End");
            Console.ReadKey();
        }
    }
} 


