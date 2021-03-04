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



    }
}
