using System;
using System.Collections.Generic;
using System.Text;
using ConsoleAppProject.Helpers;

namespace ConsoleAppProject.App03
{
    public class StudentGrades
    {
        //Constants (Grade Boundaries)

        public const int LowestMark = 0;
        public const int LowestGradeD = 40;
        public const int LowestGradeC = 50;
        public const int LowestGradeB = 60;
        public const int LowestGradeA = 70;
        public const int HighestMark = 100;

        public string[] Students { get; set; }

        public int[] Marks { get; set; }

        public int[] GradeProfile { get; set; }

        public int Grade { get; set; }

        public double Mean { get; set; }

        public int Minimum { get; set; }

        public int Maximum { get; set; }

        /// <summary>
        /// This method shows each students grade profile.
        /// </summary>
        public StudentGrades()
        {
            Students = new string[]
            {
                "Daniel", "Dylan", "Eric",
                "Georgia", "Hassan", "Hamza",
                "Jack", "Liam", "Shan",
                "Shamial"
            };

            GradeProfile = new int[(int)Grades.A + 1];
            Marks = new int[Students.Length];

        }

        public void Run()
        {
            Console.WriteLine("Student Grade Calculator By Hassan Nisar\n");

            string[] choices = new string[]
            {
                "Input Marks",
                "Output Marks",
                "Output Statistics",
                "Output GradesProfile"
            };


            int choice = ConsoleHelper.SelectChoice(choices);

            if(choice == 1)
            {
                InputMarks();
            }
        }
        /// <summary>
        /// This method allows the user to input marks for each student.
        /// </summary>
        public void InputMarks()
        {
            ConsoleHelper.OutputTitle("Inputing Student Marks");

            int index = 0;

            // Take each student in turn from the students array
            foreach(string student in Students)
            {
                // get a mark for this
                int mark = (int)ConsoleHelper.InputNumber($" Please enter a mark for {student} > ", 0,HighestMark);
                Marks[index] = mark;
                index++;
            }

            OutputMarks();
        }

        /// <summary>
        /// This method allows the user to see the marks for each student.
        /// </summary>
        public void OutputMarks()
        {
            ConsoleHelper.OutputTitle("Outputing Student Marks");

            int index = 0;
            foreach(string student in Students)
            {
                int mark = Marks[index];
                Grades grade = ConvertToGrade(mark);
                Console.WriteLine($"\t{student}  Mark = {mark} \t Grade = {grade}");
                index++;
            }
            
        }

        /// <summary>
        /// This method allows marks to be converted to grades.
        /// </summary>
        public Grades ConvertToGrade(int mark)
        {
            if (mark >= 0 && mark < LowestGradeD)
            {
                return Grades.F;
            }
            else if (mark >= 0 && mark < LowestGradeC)
            {
                return Grades.D;
            }
            else if (mark >= 0 && mark < LowestGradeB)
            {
                return Grades.C ;
            }
            else if (mark >= 0 && mark < LowestGradeA)
            {
                return Grades.B;
            }
            else
            {
                return Grades.A;
            }

        }

        /// <summary>
        /// This method calculates the stat for each student.
        /// </summary>
        public void CalculateStats()
        {
            Minimum = Marks[0];
            Maximum = Marks[0];

            double total = 0;

            foreach (int mark in Marks)
            {
                if (mark > Maximum) Maximum = mark;
                if (mark < Maximum) Minimum = mark;

                total = total += mark;
            }

            Mean = total / Marks.Length;
        }


        /// <summary>
        /// This method Calculates the Grade Profile
        /// </summary>
        public void CalculateGradeProfile()
        {
            for (int i = 0; i < GradeProfile.Length; i++)
            {
                GradeProfile[i] = 0;
            }
            foreach (int mark in Marks)
            {
                Grades grade = ConvertToGrade(mark);
                GradeProfile[(int)grade]++;
            }
        }

        public void OutputGradeProfile()
        {
            Grades grade = Grades.X;
            Console.WriteLine();

            foreach (int count in GradeProfile)
            {
                int percentage = count * 100 / Marks.Length;
                Console.WriteLine($"Grade {grade} {percentage}% Count {count}");
                grade++;
            }

            Console.WriteLine();

        }

    }   
}


    

