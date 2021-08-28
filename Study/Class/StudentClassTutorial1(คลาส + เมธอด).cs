using System;

namespace TEST
{
    class Program
    {
        
        static void Main()
        {
            Student TEST = new Student();

            TEST.Name = "Jane";
            TEST.SurName = "Jane";
            TEST.Grade = "A";

            Console.WriteLine(TEST.Grade);
            ChangeGrade(TEST);
            Console.WriteLine(TEST.Grade);

            Console.ReadKey();
        }
        static void ChangeGrade(Student TEST)
        {
            if (TEST.Grade == "A")
            {
                TEST.Grade = "F";
            }
        }

        
    }
    class Student
    {
        public string Name;
        public string SurName;
        public string Grade;
    }
}
