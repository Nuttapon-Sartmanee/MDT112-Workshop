using System;
using System.Collections.Generic;

namespace TEST
{
    class Program
    {

        static void Main()
        {
            int TotalRose;
            int TotalSunflower;

            Console.Write("Input total Rose: ");
            TotalSunflower = int.Parse(Console.ReadLine());

            Console.Write("Input total Sunflower: ");
            TotalRose = int.Parse(Console.ReadLine());

            List<Rose> ListRose = new List<Rose>();
            List<Sunflower> ListSunflower = new List<Sunflower>();

            for (int Total = 0 ; Total <= TotalRose ; Total++ )
            {
                Rose RoseVariable = new Rose();

                Console.WriteLine("Input Rose");
                Console.WriteLine("-----------");
                Console.WriteLine("");

                Console.Write("ID: ");
                RoseVariable.ID = int.Parse(Console.ReadLine());

                Console.Write("Plant name: ");
                RoseVariable.Name = Console.ReadLine();

                Console.Write("Plant description: ");
                RoseVariable.Description = Console.ReadLine();

                Console.Write("Amount: ");
                RoseVariable.Amount = int.Parse(Console.ReadLine());

                Console.Write("Height: ");
                RoseVariable.Height = Console.ReadLine();

                Console.Write("Circumference: ");
                RoseVariable.Radius = Console.ReadLine();

                ListRose.Add(RoseVariable);
                Console.Clear();
            }

            for (int Total = 0; Total <= TotalSunflower; Total++)
            {
                Sunflower SunflowerVariable = new Sunflower();

                Console.WriteLine("Input Sunflower");
                Console.WriteLine("-----------");
                Console.WriteLine("");

                Console.Write("ID: ");
                SunflowerVariable.ID = int.Parse(Console.ReadLine());

                Console.Write("Plant name: ");
                SunflowerVariable.Name = Console.ReadLine();

                Console.Write("Plant description: ");
                SunflowerVariable.Description = Console.ReadLine();

                Console.Write("Amount: ");
                SunflowerVariable.Amount = int.Parse(Console.ReadLine());

                Console.Write("Height: ");
                SunflowerVariable.Height = Console.ReadLine();

                Console.Write("Circumference: ");
                SunflowerVariable.Radius = Console.ReadLine();

                ListSunflower.Add(SunflowerVariable);
                Console.Clear();
            }

            foreach (Rose rose in ListRose)
            { 
                Console.WriteLine("Time Out!"); 
            }
            foreach (Sunflower sunflower in ListSunflower)
            {
                Console.WriteLine("Time Out!");


            }
            Console.ReadKey();
        }
    }

    class Rose
    {
        public int ID;
        public string Name;
        public string Description;
        public int Amount;
        public string Height;
        public string Radius;

        /*public Rose(int id,string name,string description,int amount,string height,string radius)
        {
            this.ID = id;
            this.Name = name;
            this.Description = description;
            this.Amount = amount;
            this.Height = height;
            this.Radius = radius;
        }
        */
    }
    class Sunflower
    {
        public int ID;
        public string Name;
        public string Description;
        public int Amount;
        public string Height;
        public string Radius;

       /* public Sunflower(int id, string name, string description, int amount, string height, string radius)
        {
            this.ID = id;
            this.Name = name;
            this.Description = description;
            this.Amount = amount;
            this.Height = height;
            this.Radius = radius;
        }
       */
    }
}
