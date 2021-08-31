using System;

namespace TEST
{
    class Program
    {
        static void Main()
        {
            MovieInfo myMovie;
            myMovie = ReadInfo();

            ShowInfo(myMovie);

            Console.ReadKey();
        }
        static void ShowInfo(MovieInfo read)
        {
            Console.WriteLine("Movie name : {0}", read.Name);
            Console.WriteLine("Movie genre : {0}", read.Genre);
            Console.WriteLine("Movie minute : {0}", read.Minute);
        }
        static MovieInfo ReadInfo()
        {
            MovieInfo Input;
            Input.Name = Console.ReadLine();
            Input.Genre = Console.ReadLine();
            Input.Minute = int.Parse(Console.ReadLine());

            return Input;
        }
        struct MovieInfo
        {
            public string Name;
            public string Genre;
            public int Minute;
        }
    }
}
