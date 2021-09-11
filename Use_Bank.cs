using System;
using System.Collections.Generic;

namespace TEST
{
    class Program
    {

        static void Main()
        {
            AomBank Test = new AomBank(500 , "EIEI" , "55555");
            Test.Deposit(500);
            Test.Deposit(500);
            Test.Deposit(500);
            Test.Withdraw(1000);

            Console.WriteLine("Remain: {0}", Test.GetMoney());
            Console.ReadKey();
        }

    }

    class Bank
    {
        public float TotalMoney;
        public string Name;
        public string Code;

        public Bank(float totalMoney , string name , string code)
        {
            this.TotalMoney = totalMoney;
            this.Name = name;
            this.Code = code;   
        }
        public void Deposit(float MoneyAdd)
        {
            if (MoneyAdd > 0)
            {
                TotalMoney += MoneyAdd;
            }
        }
        public float GetMoney()
        {
            return TotalMoney;
        }
    }
    class AomBank : Bank
    {
        public AomBank(float totalMoney, string name, string code) : base(totalMoney , name , code)
        {
            this.TotalMoney = totalMoney;
            this.Name = name;
            this.Code = code;
        }
        public void Withdraw(float Amount)
        {
            TotalMoney -= Amount; 
        }
    }

    class KrasaeBank
    { 
    
    }
}
