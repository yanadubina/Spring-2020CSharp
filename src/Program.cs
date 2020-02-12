using System;
using System.Collections.Generic;
using System.Linq;
using src;

namespace YourName.CodeLou.ExerciseProject
{
    class Program
    {
        static void Main(string[] args)
        {

            //  bool getStudentInfo = true;
            //  while (getStudentInfo)
            //  {
            //     Console.WriteLine($"Enter more info? Y/N");
            //      getStudentInfo = Console.ReadLine() == "Y";
            //   }
            var studentList = new List<Student>();
            var studentDictionary = new Dictionary<string, Student>();

            string userInput = " ";
            while (userInput != "4")
            {
                ShowMenu();
                userInput = Console.ReadLine();
                if (userInput == "1")
                {
                    var newStudent = InputStudent();
                    studentList.Add(newStudent);
                    studentDictionary.Add(newStudent.FullName, newStudent);
                }
                else if (userInput == "2")
                {
                    ShowAllStudents(studentList);
                }
                else if (userInput == "3")
                {
                    FindStudent(studentList);
                }
            }

        }
        static void FindStudent(List<Student> students)
        {
            Console.WriteLine("Enter full student name");
            var nameToFind = Console.ReadLine();
            var student = students.FirstOrDefault(student => student.FullName == nameToFind);
            PrintStudent(student);

        }
        static void PrintStudent(Student student)
        {
            Console.WriteLine(student.StudentId + " | " + student.FullName + " | " + student.ClassName);
        }

        static void ShowAllStudents(List<Student> students)
        {
            Console.WriteLine("Student ID | Name | Class");
            foreach (var student in students)
            {
                PrintStudent(student);
            }
        }

        static void ShowMenu()
        {
            Console.WriteLine("Menu");
            Console.WriteLine("1. Enter new student");
            Console.WriteLine("2. List all students");
            Console.WriteLine("3. Search for student by name");
            Console.WriteLine("4. Exit");

        }
        static Student InputStudent()
        {
            Console.WriteLine("Enter Student Id");
            var studentId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter First Name");
            var studentFirstName = Console.ReadLine();
            Console.WriteLine("Enter Last Name");
            var studentLastName = Console.ReadLine();
            Console.WriteLine("Enter Class Name");
            var className = Console.ReadLine();
            Console.WriteLine("Enter Last Class Completed");
            var lastClass = Console.ReadLine();
            Console.WriteLine("Enter Last Class Completed Date in format MM/dd/YYYY");
            var lastCompletedOn = DateTimeOffset.Parse(Console.ReadLine());
            Console.WriteLine("Enter Start Date in format MM/dd/YYYY");
            var startDate = DateTimeOffset.Parse(Console.ReadLine());

            var studentRecord = new Student();
            studentRecord.StudentId = studentId;
            studentRecord.FirstName = studentFirstName;
            studentRecord.LastName = studentLastName;
            studentRecord.ClassName = className;
            studentRecord.StartDate = startDate;
            studentRecord.LastClassCompleted = lastClass;
            studentRecord.LastClassCompletedOn = lastCompletedOn;
            Console.WriteLine($"Student Id | Name |  Class "); ;
            Console.WriteLine($"{studentRecord.StudentId} | {studentRecord.FirstName} {studentRecord.LastName} | {studentRecord.ClassName} "); ;
            //Console.ReadKey();
            return studentRecord;
        }
        
    }
}
