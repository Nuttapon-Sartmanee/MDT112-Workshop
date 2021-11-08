using System;
using System.Collections.Generic;
using System.Text;

namespace TEST
{
    class Node
    {
        protected Node next = null;
    }

    class Process : Node
    {

        public Process Next
        {
            get
            {
                return next as Process;
            }
            set
            {
                next = value;
            }
        }

        public char instruction;
        public char data;

        public Process(char inputInstruction, char inputData)
        {
            instruction = inputInstruction;
            data = inputData;
        }
    }
}