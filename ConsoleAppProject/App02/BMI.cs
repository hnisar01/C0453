using System;

namespace ConsoleAppProject.App02
{
    /// <summary>
    /// To allow the user to check their overall health by BMI
    /// </summary>
    /// <author>
    /// Hassan Nisar version 0.1
    /// </author>
    public class BMI
    {
        public const string Imperial = "Imperial";
        public const string METRIC = "Metric";

        public double Inches { get; set; }

        //all variables feet,inches,kg,stones,pounds


        private void OutputHeading()
        {
            Console.WriteLine();
            Console.WriteLine(" -------------------------");
            Console.WriteLine("   Body Mass Index Calculator      ");
            Console.WriteLine("    By Hassan Nisar       ");
            Console.WriteLine(" -------------------------");
        }

        private static string DisplayChoices(string prompt)
        {
            Console.WriteLine();
            Console.WriteLine($" 1. {Imperial}");
            Console.WriteLine($" 2. {METRIC}");
            Console.WriteLine();

            Console.Write(prompt);
            string choice = Console.ReadLine();
            return choice;
        }

        public void Run()
        {
            OutputHeading();
            string choice = SelectUnit("Please enter your choice");
            ExecuteChoice(choice);

            CalculateBMI();
        }

        private string SelectUnit(string prompt)
        {
            string choice = DisplayChoices(prompt);

            string unit = ExecuteChoice(choice);
            Console.WriteLine($" You have chosen {unit}");
            return unit;
        }

        private static string ExecuteChoice(string choice)
        {
            if (choice.Equals("1"))
            {
                InputImperialValues();
                CalculateImperialBMI();
                OutputBMI();

            }
            else if (choice == "2")
            {
                InputMetricValues();
                CalculateMetricBMI();
                OutputBMI();
            }
            return null;
        }

        private static void CalculateMetricBMI()
        {
            //BMI = (kg) / (height)2;
        }

        private static void OutputBMI()
        {
            throw new NotImplementedException();
        }

        private static void CalculateImperialBMI()
        {
            // BMI = (weight in pounds) x 703 / (height in inches)2;
        }

        private static void InputMetricValues()
        {

        }

        private static void InputImperialValues()
        {
            throw new NotImplementedException();
        }

        private void CalculateBMI()
        {
            //BMI = (weight in kg) / (height in metres)2

        }

        public void OutputMessage()
        {
        }
    }
}



