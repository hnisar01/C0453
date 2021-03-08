using System;
using System.Collections.Generic;
using System.Text;

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

        public double[] Mean { get; set; }

        public int[] Minimum { get; set; }

        public int[] Maximum { get; set; }

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

        /// <summary>
        /// This method allows the user to input marks for each student.
        /// </summary>
        public void InputMarks()
        {

        }

        /// <summary>
        /// This method allows the user to see the marks for each student.
        /// </summary>
        public void OutputMarks()
        {
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
            else return Grades.D;


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
            for int(i = 0; i < GradeProfile.Length; i++)
            {
                GradeProfile[i] = 0;
            }
            foreach (int mark in Marks)
            {
                Grade grade = ConvertToGrade(mark);
                GradeProfile[(int)grade]++;
            }

            OutputGradeProfile();
            {
                Grade grade = Grade.X;
                Console.WriteLine();

                foreach (int count in GradeProfile)
                {
                    int percentage = count * 100 / Marks.Length;
                    Console.WriteLine($"Grade {grade} {percentage}% Count {count}");
                    grade++
                }

                Console.WriteLine();
            }
        }
    }
    }
}
