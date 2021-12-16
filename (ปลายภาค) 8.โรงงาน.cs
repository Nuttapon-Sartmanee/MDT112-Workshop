using System;
using System.Collections.Generic;
using System.Text;

namespace TEST
{
    class Node { protected Node next = null; }

    class Item : Node
    {

        public Item Next
        {
            get { return next as Item; }
            set { next = value; }
        }

        public char Name;
        public Item(char name)
        {
            Name = name;
        }

    }

    class Factory
    {
        private Item root = null;

        public void Push(Item newItem)
        {
            newItem.Next = root;
            root = newItem;
        }

        public Item Pop()
        {
            Item item = root;
            root = root.Next;
            item.Next = null;
            return item;
        }
        public Item Get(int index)
        {
            Item item = root;
            while (index > 0)
            {
                if (item == null)
                {
                    throw new IndexOutOfRangeException();
                }
                item = item.Next;
                index--;
            }
            return item;
        }
    }

    class Program
    {
        static void Main()
        {
            int Total_Point = int.Parse(Console.ReadLine());
            Factory factory = new Factory();
            int currentProcess = 0;

            while (Total_Point > 0)
            { 
            char newItem = char.Parse(Console.ReadLine());
                if (currentProcess == 0 && newItem == 'A')
                {
                    currentProcess++;
                }
                else if (currentProcess == 1 && newItem == 'B')
                {
                    currentProcess++;
                }
                else if (currentProcess == 2 && newItem == 'C')
                {
                    currentProcess++;
                }
                else if (currentProcess == 3 && newItem == 'D')
                {
                    currentProcess++;
                }
                else if (currentProcess == 4 && newItem == 'E')
                {
                    currentProcess++;
                }
                else 
                {
                    factory.Push(new Item(newItem));
                }

                if (currentProcess >= 5)
                {
                    currentProcess = 0;
                    Total_Point--;
                }
            }

            Console.WriteLine(factory.Get(1)); //เอาออกมาทั้งหมดแต่หมดเวลา
            Console.ReadKey();
        }
    }
}
