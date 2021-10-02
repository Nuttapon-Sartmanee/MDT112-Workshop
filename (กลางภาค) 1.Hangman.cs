using System;

namespace Test
{

    class Program
    {
        static int IncorrectScore = 0;
        static int CorrectScore = 0;
        static int NumWord = 0;
        static char[] Answer;
        static void Main(string[] args)
        {
            Menu();
        }
        static void Menu() //MENU
        {
           Console.Clear();
           HeadStart();
           InputMenu();
        }

        static void InputMenu()//INPUT PLAY/EXIT
        {
            Console.WriteLine("1. Play game");
            Console.WriteLine("2. Exit");
            int SelectMenu = int.Parse(Console.ReadLine());
            if (SelectMenu == 1)
            {
                Gameplay();
            }
            else
            {
            }
        }
        static void Gameplay()//GAMEPLAY
        {
            Console.Clear();
            char[] Word = GenerateWord(RandomWord());//RANDOM WORD
            ShowWord(Word);
        }
        static void InputAndCheck(char[] Word)
        {
            char GameInput = InputLetter();//INPUT FROM PLAYER
            CheckInput(GameInput, Word);
        }

        static void ShowWord(char[] Word)//PRINT INTERFACE
        {
            Console.Clear();
            HeadGamePlay();
            ShowIncorrectScore();
            Console.WriteLine(Word);

            if (CorrectScore >= NumWord)//CHECK FOR WIN
            {
                Console.Clear();
                HeadGamePlay();
                ShowIncorrectScore();
                Console.WriteLine(Word);
                Console.WriteLine("You win!");
                Console.ReadKey();
            }
            else if (IncorrectScore >= 6)//CHECK FOR GAMEOVER
            {
                Console.Clear();
                HeadGamePlay();
                ShowIncorrectScore();
                Console.WriteLine(Word);
                Console.WriteLine("Game Over");
                Console.ReadKey();
            }
            else
            {
                InputAndCheck(Word);
            }
        }
        static char[] GenerateWord(WordList RandomWord)//RANDOM WORD
        {
            string NewWord = RandomWord.ToString();
            NumWord = NewWord.Length;

            Answer = NewWord.ToCharArray();
            char[] Word = new char[NumWord]; 
            for(int i = 0; i < NumWord ; i++)
            {
              Word[i] = '-';
            }
            return Word;
        }
        static void CheckInput(char Input , char[] Word)//CHECK ANSWER INPUT FROM PLAYER
        {
            int Incorrect = 0;
            for (int i = 0 ; i < NumWord; i++ ) 
            {
                if (Input == Answer[i])
                {
                    Word[i] = Input;
                    Incorrect = 0;
                    CorrectScore++;
                }
                else 
                {
                    Incorrect++;
                }
            }
            if (Incorrect > NumWord - 1)
            {
                IncorrectScore++;
            }
            ShowWord(Word);
        }
        static char InputLetter()//ANSWER INPUT
        {
            char Input;
            Console.Write("Input letter alphabet: ");
            Input = char.Parse(Console.ReadLine());
            return Input;
        }

        enum WordList//ALL WORD
        { 
            Tennis = 0,
            Football = 1,
            Badminton = 2
        }
        static WordList RandomWord()//NUMBER TO WORD
        {
            int NumRandom = RandomNum();
            WordList Word = (WordList)NumRandom;
            return Word;
        }
        static int RandomNum()//RANDOM NUMBER
        {
            Random random = new Random();
            int resultRandom = random.Next(0 , 3);
            return resultRandom;
        }
        static void ShowIncorrectScore()//FOR PRINT
        {
            Console.WriteLine("Incorrect Score: {0}" , IncorrectScore);
        }
        static void HeadStart()//FOR PRINT
        {
            Console.WriteLine("Welcome to Hangman Game");
            Console.WriteLine("----------------------------------------");
        }
        static void HeadGamePlay()//FOR PRINT
        {
            Console.WriteLine("Play Game Hangman");
            Console.WriteLine("----------------------------------------");
        }
    }
}


