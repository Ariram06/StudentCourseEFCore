
using System;
using CourseSystem.Services;
using CourseSystem.Models;

namespace CourseSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StudentService studentService = new StudentService();
            CourseService courseService = new CourseService();

            RegistrationService registrationService =
                new RegistrationService(studentService, courseService);

            
            try
            {
                studentService.LoadData();
                courseService.LoadData();
                registrationService.LoadData();

                Console.WriteLine("==================================");
                Console.WriteLine(" STUDENT COURSE REGISTRATION SYSTEM");
                Console.WriteLine("==================================");
                Console.WriteLine("Existing data loaded successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error loading saved data.");
                Console.WriteLine(ex.Message);
                Console.WriteLine("Please check your JSON files.");
                return;
            }

            bool isRunning = true;

            while (isRunning)
            {
                Console.WriteLine("\n========== MAIN MENU ==========");
                Console.WriteLine("1. Student Management");
                Console.WriteLine("2. Course Management");
                Console.WriteLine("3. Registration Management");
                Console.WriteLine("4. Reports");
                Console.WriteLine("5. Save All Data");
                Console.WriteLine("0. Exit");
                Console.Write("Enter your choice: ");

                string? choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        studentService.ShowMenu();
                        break;

                    case "2":
                        courseService.ShowMenu();
                        break;

                    case "3":
                        registrationService.ShowMenu();
                        break;

                    case "4":
                        registrationService.ShowReports();
                        break;

                    case "5":
                        SaveAllData(
                            studentService,
                            courseService,
                            registrationService);
                        break;

                    case "0":
                        SaveAllData(
                            studentService,
                            courseService,
                            registrationService);

                        isRunning = false;
                        Console.WriteLine("Thank you for using the application!");
                        break;

                    default:
                        Console.WriteLine(
                            "Invalid choice. Please enter 0, 1, 2, 3, 4, or 5.");
                        break;
                }
            }
        }

        static void SaveAllData(
            StudentService studentService,
            CourseService courseService,
            RegistrationService registrationService)
        {
            try
            {
                studentService.SaveData();
                courseService.SaveData();
                registrationService.SaveData();

                Console.WriteLine("All data saved successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving data: {ex.Message}");
            }
        }
    }
}
