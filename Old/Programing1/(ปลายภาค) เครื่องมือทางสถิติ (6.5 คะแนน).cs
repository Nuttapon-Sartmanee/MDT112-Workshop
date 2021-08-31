using System;

namespace Test
{
    class Program
    {
        static double[] Num = new double[0];
        static double[] NewNum = new double[Num.Length + 1];

        static void InputNum()
        {
            bool IsLoop = true;
            while (IsLoop == true)
            {
                string Input = Console.ReadLine();

                if (Input == "END") //CHECK FOR END
                {
                    IsLoop = false;
                    break;
                }
                else //ADD
                {
                    NewNum = new double[Num.Length + 1];
                    double InputNum;
                    double.TryParse(Input, out InputNum);
                    for (int i = 0; i < Num.Length; i++)
                    {
                        NewNum[i] = Num[i];
                    }
                    NewNum[NewNum.Length - 1] = InputNum;
                    Num = NewNum;
                }

            }
        }

        static void FindMax()
        {
            double MaxNum = 0;
            for (int i = 0; i <= Num.Length - 1; i++)
            {
                if (Num[i] > MaxNum)
                {
                    MaxNum = Num[i];
                }
                else
                {
                }
            }
            Console.WriteLine(MaxNum);
        }

        static void FindMin()
        {
            double MinNum = 10000000000;
            for (int i = 0; i <= Num.Length - 1; i++)
            {
                if (Num[i] < MinNum)
                {
                    MinNum = Num[i];
                }
                else
                {
                }
            }
            Console.WriteLine(MinNum);
        }

        static void FindMean()
        {
            double Sum = 0, Mean;

            for (int i = 0; i <= Num.Length - 1; i++)
            {
                Sum = Sum + Num[i];
            }
            Mean = Sum / Num.Length;
            Console.WriteLine(Mean);
        }

        static void InputMode()
        {
            bool IsLoop = true;
            while (IsLoop == true)
            {
                string Input = Console.ReadLine();
                if (Input == "FindMax")
                {
                    FindMax();
                    IsLoop = false;
                }
                else if (Input == "FindMin")
                {
                    FindMin();
                    IsLoop = false;
                }
                else if (Input == "FindMean")
                {
                    FindMean();
                    IsLoop = false;
                }
                else
                {
                    Console.WriteLine("Invalid mode");
                }
            }

        }

        static void Main()
        {
            InputNum();
            InputMode();

            Console.ReadKey();
        }
    }
} 


