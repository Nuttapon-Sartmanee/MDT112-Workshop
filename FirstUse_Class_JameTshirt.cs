using System;

namespace Test
{
    class Tshirt
    {
        public string Size;
        public string Color;
        public float Price;
        public string Image;
    }

    class User
    {
        public string Name;
        public string Email;
    }

    class Address
    {
        public string Street;
        public string City;
        public string Zipcode;
    }

    class ShoppingCart
    {
        public float FinalPrice;
        public void TotalPrice(float Tshirt1 ,float Tshirt2 ,float Tshirt3)
        {
            FinalPrice = Tshirt1 + Tshirt2 + Tshirt3;
            Console.WriteLine("");
            Console.WriteLine("Your total is " + FinalPrice + " Baht");
        }
        public void TotalTshirt(Tshirt Tshirt1 , Tshirt Tshirt2 , Tshirt Tshirt3)
        {
            Console.WriteLine("Your Cart");
            Console.WriteLine("Size: " + Tshirt1.Size + " Color:" + Tshirt1.Color + " Price: " + Tshirt1.Price);
            Console.WriteLine("Size: " + Tshirt2.Size + " Color:" + Tshirt2.Color + " Price: " + Tshirt2.Price);
            Console.WriteLine("Size: " + Tshirt3.Size + " Color:" + Tshirt3.Color + " Price: " + Tshirt3.Price);
        }
        public void TotalInfo(Address AddressUser , User User)
        {
            Console.WriteLine("");
            Console.WriteLine("Your Information");
            Console.WriteLine("Name: " + User.Name);
            Console.WriteLine("Email: " + User.Email);
            Console.WriteLine("Address: " + AddressUser.City + " " + AddressUser.Street + " " + AddressUser.Zipcode);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            User JameUser = new User();
            JameUser.Name = "Jame Watson";
            JameUser.Email = "jame@gmail.com";

            Address JameAddress = new Address();
            JameAddress.City = "นครปฐม";
            JameAddress.Street = "ถนนพุทธมณฑล";
            JameAddress.Zipcode = "10180";

            Tshirt Tshirt1 = new Tshirt();
            Tshirt1.Size = "L";
            Tshirt1.Color = "Red";
            Tshirt1.Price = 500;
            Tshirt1.Image = "LRed.png";

            Tshirt Tshirt2 = new Tshirt();
            Tshirt2.Size = "M";
            Tshirt2.Color = "Black";
            Tshirt2.Price = 250;
            Tshirt1.Image = "MBlack.png";

            Tshirt Tshirt3 = new Tshirt();
            Tshirt3.Size = "S";
            Tshirt3.Color = "Blue";
            Tshirt3.Price = 625;
            Tshirt1.Image = "SBlue.png";

            ShoppingCart JameCart = new ShoppingCart();

            JameCart.TotalTshirt(Tshirt1,Tshirt2,Tshirt3);
            JameCart.TotalPrice(Tshirt1.Price, Tshirt2.Price, Tshirt3.Price);
            JameCart.TotalInfo(JameAddress , JameUser);

            Console.ReadKey();
        }
    }
} 


