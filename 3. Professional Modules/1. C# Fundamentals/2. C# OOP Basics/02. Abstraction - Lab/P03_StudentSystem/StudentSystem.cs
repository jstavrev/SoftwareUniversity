namespace P03_StudentSystem
{
    using System;
    using System.Collections.Generic;

    public class StudentSystem
    {
        private Dictionary<string, Student> studentsInformation;

        public StudentSystem()
        {
            this.StudentsInformation = new Dictionary<string, Student>();
        }

        public Dictionary<string, Student> StudentsInformation
        {
            get { return studentsInformation; }
            private set { studentsInformation = value; }
        }

        public void ExecuteCommand()
        {
            string[] args = Console.ReadLine().Split();

            if (args[0] == "Create")
            {
                var name = args[1];
                var age = int.Parse(args[2]);
                var grade = double.Parse(args[3]);
                if (!studentsInformation.ContainsKey(name))
                {
                    var student = new Student(name, age, grade);
                    StudentsInformation[name] = student;
                }
            }
            else if (args[0] == "Show")
            {
                var name = args[1];
                if (StudentsInformation.ContainsKey(name))
                {
                    var student = StudentsInformation[name];
                    string printStudent = $"{student.Name} is {student.Age} years old.";

                    if (student.Grade >= 5.00)
                    {
                        printStudent += " Excellent student.";
                    }
                    else if (student.Grade < 5.00 && student.Grade >= 3.50)
                    {
                        printStudent += " Average student.";
                    }
                    else
                    {
                        printStudent += " Very nice person.";
                    }

                    Console.WriteLine(printStudent);
                }

            }
            else if (args[0] == "Exit")
            {
                Environment.Exit(0);
            }
        }
    }
}