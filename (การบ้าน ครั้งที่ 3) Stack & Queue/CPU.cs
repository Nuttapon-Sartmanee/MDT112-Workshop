using System;
using System.Collections.Generic;
using System.Text;

namespace TEST
{
    class CPU
    {
        private Process root = null;
        public void Push(Process newInstruction)
        {
            if (root == null)
            {
                root = newInstruction;
            }
            else
            {
                Process instruction = root;
                while (instruction.Next != null)
                {
                    instruction = instruction.Next;
                }
                instruction.Next = newInstruction;
            }
        }
        public Process Pop()
        {
            Process instruction = root;
            root = root.Next;
            instruction.Next = null;
            return instruction;
        }

        public Process Get(int index)
        {
            Process instruction = root;
            while (index > 0)
            {
                if (instruction == null)
                {
                    throw new IndexOutOfRangeException();
                }
                instruction = instruction.Next;
                index--;
            }
            return instruction;
        }
    }
}