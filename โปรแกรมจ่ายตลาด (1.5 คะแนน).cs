using System;

namespace Test
{
    class Program
    {
        static int NumList;
        static void Menu(string[] List)
        {
            List = AddList(List);

            ReadList(List);
            
            CheckList(List);
        }
        static void ReadList(string[] List)
        {
            Console.WriteLine();
            Console.WriteLine("This is your list.");
            for (int i = 1; i < List.Length; i++)
            {
                Console.Write(i + ".");
                Console.Write(List[i]);
                Console.WriteLine();
            }
        }
        static string[] AddList(string[] List)
        {
            Console.WriteLine("Please input your list :");
            Console.WriteLine("(If the list is completed.Please input \"END\".)");
            bool IsLoop = true;
            while (IsLoop == true)
            {
                string ListInput = Console.ReadLine();
                if (ListInput == "END") //CHECK FOR END
                {
                    IsLoop = false;
                    break;
                }
                else //ADD
                {
                    string[] NewList = new string[List.Length + 1];
                    for (int i = 0; i < List.Length; i++)
                    {
                        NewList[i] = List[i];
                    }
                    NewList[NewList.Length - 1] = ListInput;
                    List = NewList;
                    NumList = List.Length - 1;
                }

            }
            return List;
        }
        static void CheckList(string[] List)
        {
            bool IsLoop = true;

            while (IsLoop == true)
            {
                Console.WriteLine("Please input number of your list for checking" +
                    ".");
                Console.WriteLine("If you want to cancel the list. Please input \"CANCEL\".");
                string Input = Console.ReadLine();
                if (Input == "CANCEL") //CHECK FOR CANCEL
                {
                    break;
                }
                else
                {
                    int InputNum;
                    int.TryParse(Input, out InputNum); //CONVERT STRING TO INT
                    if (InputNum > List.Length - 1) //CHECK LENGHT OF LIST
                    {
                        Console.WriteLine();
                        Console.WriteLine("It's out of list!");
                    }
                    else
                    {
                        List[InputNum] = List[InputNum] + " - CHECKED";
                        NumList--;
                        ReadList(List);
                        if (NumList == 0)//CHECK NUM OF LIST 
                        {
                            Console.WriteLine();
                            Console.WriteLine("Your list is Completed!");
                            Console.ReadKey();
                            break;
                        }
                        else{ }
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            string[] List = new string[1];
            Menu(List);
        }
    }
}
