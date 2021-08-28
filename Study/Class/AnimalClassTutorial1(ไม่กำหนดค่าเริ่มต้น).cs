using System;

namespace TEST
{
    class Program
    {
        
        static void Main()
        {
            Animal Rabbit = new Animal();

            Rabbit.Name = "FLUKE";
            Rabbit.Gender = "Female";
            Rabbit.Birthday = "11/11/2544";

            Console.WriteLine(Rabbit.Name);

            Console.ReadKey();
        }
    }
    class Animal
    {
        public string Name;
        public string Gender;
        public string Birthday;
    }
}
