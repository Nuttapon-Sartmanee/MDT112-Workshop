using System;

namespace TEST
{
    class Program
    {
        
        static void Main()
        {
            Swordman Arenaiz6 = new Swordman();
            Console.WriteLine(Arenaiz6.HP);

            Console.ReadKey();
        }
    }
    class Swordman
    {
        public int HP;
        public int EXP;
        public int ATK;
        public int DEF;

        public Swordman()
        {
            HP = 300;
            EXP = 0;
            ATK = 1;
            DEF = 1;
        }

        public void Walk()
        {
            Console.WriteLine("Walk");
        }
        public void Jump()
        {
            Console.WriteLine("Jump");
        }
        public void Sit()
        {
            Console.WriteLine("Sit");
        }
        public void Dead()
        {
            Console.WriteLine("Dead");
        }
        
    }
}
