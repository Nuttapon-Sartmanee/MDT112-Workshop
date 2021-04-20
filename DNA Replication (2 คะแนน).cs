using System;

namespace _2_DNA_Replication
{
    class Program
    {
        static void Menu()
        {

            string InputHalfDNA = Console.ReadLine();
            bool IsValid = IsValidSequence(InputHalfDNA);
            if (IsValid == true)
            {
                Console.WriteLine("Current half DNA sequence: {0}", InputHalfDNA);
                Replicate(InputHalfDNA);

            }
            else
            {
                Console.WriteLine("That half DNA sequence is invalid.");
                RestartOrEnd();
            }

        }

        static void Replicate(string InputHalfDNA)
        {
            Console.Write("Do you want to replicate it ? (Y/N) : ");

            bool Loop = true;
            string Replicated = ReplicateSeqeunce(InputHalfDNA);

            while (Loop == true)
            {
                string Ans = Console.ReadLine();

                switch (Ans)
                {
                    case "Y":
                        Console.WriteLine("Replicated half DNA sequence : {0}",Replicated);
                        Loop = false;
                        RestartOrEnd();
                        break;

                    case "N":
                        Loop = false;
                        RestartOrEnd();
                        break;

                    default:
                        Console.WriteLine("Please input Y or N.");
                        break;
                }

            }
        }

        static void RestartOrEnd()
        {
            Console.WriteLine("Do you want to process another sequence ? (Y / N) : ");

            bool Loop = true;

            while (Loop == true)
            {
                string Ans = Console.ReadLine();

                switch (Ans) 
                {  
                    case "Y":
                        Menu();
                        Loop = false;
                        break;

                    case "N":
                        Loop = false;
                        break;

                    default:
                        Console.WriteLine("Please input Y or N.");
                        break;
                }
            
            }
        }
        static string ReplicateSeqeunce(string halfDNASequence)
        {
            string result = "";
            foreach (char nucleotide in halfDNASequence)
            {
                result += "TAGC"["ATCG".IndexOf(nucleotide)];
            }
            return result;
        }

        static bool IsValidSequence(string halfDNASequence)
        {
            foreach (char nucleotide in halfDNASequence)
            {
                if (!"ATCG".Contains(nucleotide))
                {
                    return false;
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            Menu();
        }

    }
}
