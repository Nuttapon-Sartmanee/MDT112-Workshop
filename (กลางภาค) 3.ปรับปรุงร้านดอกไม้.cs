using System;
using System.Collections.Generic;

namespace Test
{

    class Program
    {
        static void Main(string[] args)
        {
            FlowerStore flowerStore = new FlowerStore();
            Menu(flowerStore);
        }
        static void Menu(FlowerStore flowerStore)
        {
            PrintOrder(flowerStore);
            SelectFlower(flowerStore);
            selectExit(flowerStore);
        }
        static void selectExit(FlowerStore flowerStore)
        {
            string decide = "No";
            Console.WriteLine("You can stop this progress ? exit for >> exit << progress and press any key for continue");
            decide = Console.ReadLine();
            if (decide == "exit")
            {
                ExitProgram(flowerStore);
            }
            else
                Menu(flowerStore);
        }
        static void SelectFlower(FlowerStore flowerStore) 
        {
            string selectFlower;
            selectFlower = Console.ReadLine();
            switch (selectFlower)
            {
                case "1":
                    flowerStore.addToCart(flowerStore.flowerList[0]);
                    Console.WriteLine("Added " + flowerStore.flowerList[0]);
                    break;
                case "2":
                    flowerStore.addToCart(flowerStore.flowerList[1]);
                    Console.WriteLine("Added " + flowerStore.flowerList[1]);
                    break;
                default:
                    Console.WriteLine("Not Added to cart. found select number of flower");
                    break;
            }
        }
        static void PrintOrder(FlowerStore flowerStore)
        {
            Console.WriteLine("Select number for buy flower :");
            foreach (string i in flowerStore.flowerList)
            {
                Console.Write((flowerStore.flowerList.IndexOf(i) + 1) + " ");
                Console.WriteLine(i);
            }
        }
        static void ExitProgram(FlowerStore flowerStore)
        {
            Console.Write("Current my cart");
            flowerStore.showCart();
            Console.ReadKey();
        }
    }
    class FlowerStore
    {
        public List<string> flowerList = new List<string>();
        List<string> cart = new List<string>();
        public FlowerStore()
        {
            flowerList.Add("Rose");
            flowerList.Add("Lotus");
        }
        public void addToCart(string name)
        {
            cart.Add(name);
        }

        public void showCart()
        {
            if (cart.Count == 0)
            {
                Console.WriteLine("Cart is empty");
            }
            else
            {
                Console.WriteLine("My Cart :");
                foreach (string i in cart)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}


