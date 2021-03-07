using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppProject.App03
{
    class StudentGrades
    {
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
            
        }

        /// <summary>
        /// This method calculates the stat for each student.
        /// </summary>
        public void CalculateStats()
        {

        }

        /// <summary>
        /// This method Calculates the Grade Profile
        /// </summary>
        public void CalculateGradeProfile()
        {

        }



    }
}
