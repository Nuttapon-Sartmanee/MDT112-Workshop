using System;

namespace Test
{
    class Program
    {
        static int numProblem = 3;
        static int DifficultyNum = 0;
        static double Score = 0;
        enum Difficulty
        {
            Easy,
            Normal,
            Hard
        }

        struct Problem
        {
            public string Message;
            public int Answer;

            public Problem(string message, int answer)
            {
                Message = message;
                Answer = answer;
            }
        }

        static Problem[] GenerateRandomProblems(int numProblem)
        {
            Problem[] randomProblems = new Problem[numProblem];

            Random rnd = new Random();
            int x, y;

            for (int i = 0; i < numProblem; i++)
            {
                x = rnd.Next(50);
                y = rnd.Next(50);
                if (rnd.NextDouble() >= 0.5)
                    randomProblems[i] =
                    new Problem(String.Format("{0} + {1} = ?", x, y), x + y);
                else
                    randomProblems[i] =
                    new Problem(String.Format("{0} - {1} = ?", x, y), x - y);
            }

            return randomProblems;
        }

        static void GamePlay()
        {
            int AnswerInput;
            Problem[] CurrentProblem = GenerateRandomProblems(numProblem);
            double ScoreEarly = 0;

            long TimeFisrt = DateTimeOffset.Now.ToUnixTimeSeconds();

            for (int i = 0; i < CurrentProblem.Length; i++)
            {
                Console.WriteLine(CurrentProblem[i].Message);
                AnswerInput = int.Parse(Console.ReadLine());
                if (AnswerInput == CurrentProblem[i].Answer)
                {
                    ScoreEarly++;
                }
                else
                {

                }
            }

            long TimeEnd = DateTimeOffset.Now.ToUnixTimeSeconds();
            long TimeUse = TimeEnd - TimeFisrt;

            Score = CalScore(ScoreEarly,TimeUse);

            Menu();
        }
        static double CalScore(double ScoreEarly, long TimeUse)
        {
            Score = (ScoreEarly / numProblem) * ((25 - (DifficultyNum * DifficultyNum)) / (Math.Max( TimeUse , 25 - (DifficultyNum * DifficultyNum)))) * (((2 * DifficultyNum) + 1) * ((2 * DifficultyNum) + 1));
            return Score;
        }

        static void Menu()
        {
            bool IsLoop = true;
            Console.WriteLine("Score: {0}, Difficulty: {1}", Score, (Difficulty)DifficultyNum);

            while (IsLoop == true)
            {
                int ModeSelect = int.Parse(Console.ReadLine());
                if (ModeSelect == 0)
                {
                    GamePlay();
                    IsLoop = false;
                }
                else if (ModeSelect == 1)
                {
                    Setting();
                    IsLoop = false;
                }
                else if (ModeSelect == 2)
                {
                    IsLoop = false;
                }
                else
                {
                    Console.WriteLine("Please input 0 - 2.");
                }
            }
        }

        static void Setting()
        {
            bool IsLoop = true;
            Console.WriteLine("Score: {0}, Difficulty: {1}", Score, (Difficulty)DifficultyNum);

            while (IsLoop == true)
            {
                int DifficultySelect = int.Parse(Console.ReadLine());
                if (DifficultySelect == 0)
                {
                    DifficultyNum = 0;
                    numProblem = 3;
                    IsLoop = false;
                    Menu();
                }
                else if (DifficultySelect == 1)
                {
                    DifficultyNum = 1;
                    numProblem = 5;
                    IsLoop = false;
                    Menu();
                }
                else if (DifficultySelect == 2)
                {
                    DifficultyNum = 2;
                    numProblem = 7;
                    IsLoop = false;
                    Menu();
                }
                else
                {
                    Console.WriteLine("Please input 0 - 2.");
                }
            }
        }

        static void Main(string[] args)
        {
            Menu();
        }
        //By.Nuttapon.Sartmanee.63120501026;
    }
}
