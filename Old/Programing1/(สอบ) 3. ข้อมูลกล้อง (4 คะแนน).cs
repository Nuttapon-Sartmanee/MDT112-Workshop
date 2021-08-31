using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEST
{
    class Program
    {

        static void Main(string[] args)
        {
            string mode = Console.ReadLine();
            bool LoopMain = true;

            while (LoopMain == true)
            {
                float filmBackWidth = float.Parse(Console.ReadLine());
                if (filmBackWidth > 0)
                {
                    LoopMain = false;
                    float fLenght, fov;
                    if (mode == "fLenght")
                    {
                        bool LoopfLenght = true;
                        while (LoopfLenght == true)
                        {
                            fLenght = float.Parse(Console.ReadLine());
                            if (fLenght > 0)
                            {
                                LoopfLenght = false;
                                fov = (float)(2 * Math.Atan(filmBackWidth / 2 * fLenght));
                                Console.WriteLine("fLenght = {0} , fov = {1}", fLenght, fov);
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.WriteLine("Invalid fLenght. Please input again.");
                            }
                        }


                    }
                    else if (mode == "fov")
                    {
                        bool Loopfov = true;
                        while (Loopfov == true)
                        {
                            fov = float.Parse(Console.ReadLine());
                            if (fov > 0.1 && fov < 6.28)
                            {
                                Loopfov = false;
                                fLenght = (float)(filmBackWidth / (2 * Math.Tan(fov / 2)));
                                Console.WriteLine("fLenght = {0} , fov = {1}", fLenght, fov);
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.WriteLine("Invalid fov. Please input again.");
                            }
                        }

                    }
                }
                else
                {
                    Console.WriteLine("Invalid filmBackWidth. Please input again.");
                }
            }

        }

    }
}