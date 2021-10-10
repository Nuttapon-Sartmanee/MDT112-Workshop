using System;
using System.Collections.Generic;

namespace TEST
{
    enum Menu
    {
        RegisterNewStudent = 1,
        RegisterNewTeacher,
        GetListPersons,
        ClearList,
        ExitProgram
    }

    namespace Employee
    {
        class Program
        {
            static int AllTotalStudent = 0, AllTotalTeacher = 0, AllTotal = 0;
            static PersonList personList;

            static void Main(string[] args)
            {
                
                PreparePersonListWhenProgramIsLoad();
                PrintMenuScreen();
            }

            static void PreparePersonListWhenProgramIsLoad()
            {
                Program.personList = new PersonList();
            }

            static void PrintMenuScreen()
            {
                Console.Clear();
                
                PrintHeader();
                PrintListMenu();
                InputMenuFromKeyboard();
            }

            static void PrintHeader()
            {
                Console.WriteLine("Welcome to registration new user school application.");
                Console.WriteLine("----------------------------------------------------");
            }

            static void PrintListMenu()
            {
                Console.WriteLine("1. Register new student.");
                Console.WriteLine("2. Register new Teacher.");
                Console.WriteLine("3. Get List Persons.");
                Console.WriteLine("4. Clear the list.");
                Console.WriteLine("5. Exit the programs.");
            }

            static void InputMenuFromKeyboard()
            {
                Console.Write("Please Select Menu: ");
                Menu menu = (Menu)(int.Parse(Console.ReadLine()));

                PresentMenu(menu);
            }

            static void PresentMenu(Menu menu)
            {
                if (menu == Menu.RegisterNewStudent)
                {
                    ShowInputRegisterNewStudentScreen();
                }
                else if (menu == Menu.RegisterNewTeacher)
                {
                    ShowInputRegisterNewTeacherScreen();
                }
                else if (menu == Menu.GetListPersons)
                {
                    ShowGetListPersonScreen();
                }
                
                else if (menu == Menu.ClearList)
                {
                    ClearList();
                }
                else if (menu == Menu.ExitProgram)
                {
                
                }
                else
                {
                    ShowMessageInputMenuIsInCorrect();
                }
            }

            static void ShowInputRegisterNewStudentScreen()
            {
                Console.Clear();
                PrintHeaderRegisterStudent();

                int totalStudent = TotalNewStudents();
                AllTotalStudent += totalStudent;
                InputNewStudentFromKeyboard(totalStudent);
            }

            static void ShowInputRegisterNewTeacherScreen()
            {
                Console.Clear();
                PrintHeaderRegisterTeacher();

                int totalTeacher = TotalNewTeacher();
                AllTotalTeacher += totalTeacher;
                InputNewTeacherFromKeyboard(totalTeacher);
            }

            static void ShowGetListPersonScreen()
            {
                Console.Clear();
                
                Program.personList.FetchPersonsList();
                ShowTotalAll();

                InputExitFromKeyboard();
            }
            static void ShowTotalAll()
            {
                Console.WriteLine("Total of student: {0}" ,AllTotalStudent);
                Console.WriteLine("Total of teacher: {0}" , AllTotalTeacher);
                Console.WriteLine("Total of all: {0}", AllTotal);
            }

            static void ClearList()
            {
                Console.Clear();
                Program.personList.ClearList();
                AllTotalStudent = 0;
                AllTotalTeacher = 0;
                AllTotal = 0;

                Console.WriteLine("List Cleared.");
                Console.WriteLine("");
                Console.WriteLine("Press anykey to back to menu...");
                Console.ReadKey();

                Console.Clear();
                PrintMenuScreen();
            }

            static void InputExitFromKeyboard()
            {
                Console.WriteLine("");
                Console.WriteLine("Press anykey to back to menu...");
                Console.ReadKey();

                Console.Clear();
                PrintMenuScreen();
            }

            static void InputNewTeacherFromKeyboard(int totalTeacher)
            {
                for (int i = 0; i < totalTeacher; i++)
                {
                    Console.Clear();
                    PrintHeaderRegisterTeacher();
                    AllTotal++;
                    Teacher teacher = CreateNewTeacher();
                    Program.personList.AddNewPerson(teacher);
                }

                Console.Clear();
                PrintMenuScreen();
            }

            static void InputNewStudentFromKeyboard(int totalStudent)
            {
                for (int i = 0; i < totalStudent; i++)
                {
                    Console.Clear();
                    PrintHeaderRegisterStudent();
                    AllTotal++;
                    Student student = CreateNewStudent();
                    Program.personList.AddNewPerson(student);
                }

                Console.Clear();
                PrintMenuScreen();
            }

            static Student CreateNewStudent()
            {
                return new Student(InputName(),
                 InputAddress(),
                 InputCitizenID(),
                 InputStudentID());
            }

            static Teacher CreateNewTeacher()
            {
                return new Teacher(InputName(),
                InputAddress(),
                InputCitizenID(),
                InputEmployeeID());
            }

            static string InputName()
            {
                Console.Write("Name: ");

                return Console.ReadLine();
            }

            static string InputStudentID()
            {
                Console.Write("Student ID: ");

                return Console.ReadLine();
            }

            static string InputAddress()
            {
                Console.Write("Address: ");

                return Console.ReadLine();
            }

            static string InputCitizenID()
            {
                Console.Write("Citizen ID: ");

                return Console.ReadLine();
            }

            static string InputEmployeeID()
            {
                Console.Write("Employee ID: ");

                return Console.ReadLine();
            }

            static int TotalNewStudents()
            {
                Console.Write("Input Total new Student: ");

                return int.Parse(Console.ReadLine());
            }

            static int TotalNewTeacher()
            {
                Console.Write("Input Total new Teacher: ");

                return int.Parse(Console.ReadLine());
            }

            static void PrintHeaderRegisterStudent()
            {
                Console.WriteLine("Register new student.");
                Console.WriteLine("---------------------");
            }

            static void PrintHeaderRegisterTeacher()
            {
                Console.WriteLine("Register new teacher.");
                Console.WriteLine("---------------------");
            }

            static void ShowMessageInputMenuIsInCorrect()
            {
                Console.Clear();
                Console.WriteLine("Menu Incorrect Please try again.");
                InputMenuFromKeyboard();
            }
        }

    }

    class PersonList
    {
        private List<Person> personList;

        public PersonList()
        {
            this.personList = new List<Person>();
        }

        public void AddNewPerson(Person person)
        {
            this.personList.Add(person);
        }

        public void ClearList()
        {
            this.personList.Clear();
        }

        public void FetchPersonsList()
        {
            Console.WriteLine("List Persons");
            Console.WriteLine("---------------------");
            foreach (Person person in this.personList)
            {
                if (person is Student)
                {
                    Console.WriteLine("Name: {0} \nType: Student \n", person.GetName());
                }
                else if (person is Teacher)
                {
                    Console.WriteLine("Name: {0} \nType: Teacher \n", person.GetName());
                }
            }
        }
    }

    class Person
    {
        protected string name;
        protected string address;
        protected string citizenID;

        public Person(string name, string address, string citizenID)
        {
            this.name = name;
            this.address = address;
            this.citizenID = citizenID;
        }

        public string GetName()
        {
            return this.name;
        }

    }
    class Teacher : Person
    {
        private string employeeID;

        public Teacher(string name, string address, string citizenID, string employeeID)
        : base(name, address, citizenID)
        {
            this.employeeID = employeeID;
        }

    }

    class Student : Person
    {
        private string studentID;

        public Student(string name, string address, string citizenID, string studentID)
        : base(name, address, citizenID)
        {
            this.studentID = studentID;
        }

    }
}