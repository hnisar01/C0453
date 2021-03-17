using ConsoleAppProject.App01;
using ConsoleAppProject.App02;
using ConsoleAppProject.App03;
using ConsoleAppProject.App04;
using ConsoleAppProject.Helpers;
using System;

namespace ConsoleAppProject
{
    /// <summary>
    /// The main method in this class is called first
    /// when the application is started.  It will be used
    /// to start Apps 01 to 05 for CO453 CW1
    /// 
    /// This Project has been modified by:
    /// Hassan Nisar 13/02/2021
    /// </summary>
    public static class Program
    {
        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            
            Console.WriteLine("BNU CO453 Applications Programming 2020-2021!");
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine($" 1. App01 Distance Converter");
            Console.WriteLine($" 2. App02 BMI");
            Console.WriteLine($" 3. App03 Student Grades");
            Console.WriteLine($" 4. App04 Social Network");

            Console.Write("Please select an app > ");
            string choice = Console.ReadLine();
            

            if (choice.Equals("1"))
            {
                DistanceConverter converter = new DistanceConverter();
                converter.CalculatetoDistance();
            }
            else if (choice == "2")
            {
                BMI bmi = new BMI();
                bmi.Run();
            }
            else if (choice.Equals("3"))
            {
                StudentGrades studentGrades = new StudentGrades();
                studentGrades.Run();
            }
            else if (choice.Equals("4"))
            {
                NetworkApp app04 = new NetworkApp();
                app04.DisplayMenu();
                

            }
            

        }
    }
}
