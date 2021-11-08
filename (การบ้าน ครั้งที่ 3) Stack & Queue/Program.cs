using System;

namespace TEST
{

    class Program
    {
        static int numCPUcycles = 0;
        static int numProcess = 0;
        static int CPU_1 = 0;
        static int CPU_2 = 0;
        static int CPU_3 = 0;
        static int CPU_4 = 0;

        static void Main()
        {
            CPU cpu = new CPU();
            
            InputAll(cpu);

            while (numProcess >= 0)
            {
                //break เพราะ
                break;
                if (CPU_1 > 0 && CPU_2 > 0 && CPU_3 > 0 && CPU_4 > 0)
                {
                    numCPUcycles++;
                }
            }

            Console.WriteLine("CPU cycles needed: {0}" , numCPUcycles);
            Console.WriteLine("Dai kare nee kub T-T");
            Console.ReadKey();

        }
        static void InputAll(CPU cpu)
        {
            while (true)
            {
                string Input = Console.ReadLine();
                if (Input == "?")
                {
                    break;
                }
                else
                {
                    char InputInstruction = Input[0];
                    char Inputdata = Input[1];
                    cpu.Push(new Process(InputInstruction, Inputdata));
                    numProcess++;
                }
            }
        }
    }
}