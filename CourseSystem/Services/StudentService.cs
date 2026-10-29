
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using CourseSystem.Models;
namespace CourseSystem.Services
{
    public class StudentService
    {
        private List<Student> students = new List<Student>();
        public void AddStudent()
        {
            Console.WriteLine("Eneter Student Name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter Student Id: ");
            string id = Console.ReadLine();

            Console.WriteLine("Enter Student Age: ");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Student Id: ");
            string number = Console.ReadLine();

            Student std = new Student(name, id, age, number);
            students.Add(std);
            SaveData();

            Console.WriteLine("Student added successfuly");

         
            

        }
        public void ShowMenu()
        {
            bool running = true;

            while (running)
            {
                Console.WriteLine("\n====== STUDENT MENU ======");
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. Display All Students");
                Console.WriteLine("3. Search Student By ID");
                Console.WriteLine("4. Search Student By Name");
                Console.WriteLine("5. Update Student");
                Console.WriteLine("6. Delete Student");
                Console.WriteLine("0. Back to Main Menu");
                Console.Write("Enter choice: ");

                string? choice = Console.ReadLine();

                try
                {
                    switch (choice)
                    {
                        case "1":
                            AddStudent();
                            break;

                        case "2":
                            DisplayAllStudents();
                            break;

                        case "3":
                            SearchStudentById();
                            break;

                        case "4":
                            SearchStudentsByName();
                            break;

                        case "5":
                            UpdateStudent();
                            break;

                        case "6":
                            DeleteStudent();
                            break;

                        case "0":
                            running = false;
                            break;

                        default:
                            Console.WriteLine("Invalid menu choice.");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Operation failed: {ex.Message}");
                }
            }
        }
    }
}
