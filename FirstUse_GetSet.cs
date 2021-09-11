using System;
using System.Collections.Generic;

namespace TEST
{
    class Program
    {
        
        static void Main()
        {
            Stock test = new Stock();
            Console.WriteLine(test.CurrentPrice);
            Console.ReadKey();
        }

    }
    class Stock
    {
        private float currentprice = 2000;


        public float CurrentPrice
        {
            get{ return currentprice * 2; }
        }

    }
}
