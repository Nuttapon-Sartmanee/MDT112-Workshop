using System;
using System.Collections.Generic;

namespace TEST
{
    class Program
    {

        static void Main()
        {

            Console.ReadKey();
        }

    }
    class Student: Person
    {
        private string Grade;

        public Student(string firstName, string lastName): base(firstName,lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public void RecordGrade (string grade)
        {
            this.Grade = grade;
        }

        public string GetGrade()
        {
            return Grade;
        }
    }

    class Person
    {
        public string FirstName;
        public string LastName;

        public Person(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }
    }
    class Teacher
    {
        public string FirstName;
        public string LastName;

        public Teacher (string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }
    }
}
