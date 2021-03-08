using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleAppProject.App03;

namespace ConsoleApps.Tests
{
    [TestClass]
    public class TestStudentGrades
    {
        private readonly StudentGrades converter = new ConsoleAppProject.App03.StudentGrades();

        public int[] testMarks;

        public TestStudentGrades()
        {
            testMarks = new int[]
            {
                10, 20, 30, 40, 50, 60, 70, 80, 90, 100
            };
        }

        
        [TestMethod]
        public void TestCovert0ToGradeF()
        {
            ///Arrange

            Grades expectedGrade = Grades.F;

            ///Act

            Grades actualGrade = converter.ConvertToGrade(0);

            ///Assert

            Assert.AreEqual(expectedGrade, actualGrade);
        }

        [TestMethod]
        public void TestCovert39ToGradeF()
        {
            ///Arrange

            Grades expectedGrade = Grades.F;

            ///Act

            Grades actualGrade = converter.ConvertToGrade(0);

            ///Assert

            Assert.AreEqual(expectedGrade, actualGrade);
        }

        [TestMethod]
        public void TestCalculateMean()
        {
            converter.Marks = testMarks;
            double expectedMean = 55.0;
            converter.CalculateStats();

            Assert.AreEqual(expectedMean, converter.Mean);
        }

       
        public void TestCalculateMin()
        {
            //Arrange
            StudentGrades.Marks = StatsMarks;
            int expectedMin = 10;

            //Act
            studentGrades.CalculateStats();

            //Assert
            Assert.AreEqual(expectedMin, StudentGrades.Minimum);
        }


        [TestClass]
        public class StudentGradesTest
        {
            private readonly StudentGrades
                studentGrades = new StudentGrades();

            private readonly int[] StatsMarks = new int[]
            {
                10, 20, 30, 40, 50, 60, 70, 80, 90, 100
            };
           
        }

        [TestMethod]
        public void TestGradeProfile()
        {
            //Arrange

            studentGrades.Marks = StatsMarks;
            bool expectedProfile = false;

            //Act
            studentGrades.CalculateGradeProfile();

            expectedProfile = ( (studentGrades.GradeProfile[0] == 3) &&
                                (studentGrades.GradeProfile[1] == 1) &&
                                (studentGrades.GradeProfile[2] == 1) &&
                                (studentGrades.GradeProfile[3] == 1) &&
                                (studentGrades.GradeProfile[4] == 4)) &&;

            //Assert
            Assert.IsTrue(expectedProfile);

        }
    }
}
