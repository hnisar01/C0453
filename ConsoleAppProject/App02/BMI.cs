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
        public double Kilograms { get; set; }
        public double Pounds { get; set; }
        public double Feet { get; set; }
        public double Stones { get; set; }
        public double Centimeters { get; set; }
        public double Meters { get; set; }

        public double Index { get; set; }

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

        }

        private string SelectUnit(string prompt)
        {
            string choice = DisplayChoices(prompt);

            string unit = ExecuteChoice(choice);
            Console.WriteLine($" You have chosen {unit}");
            return unit;
        }

        private string ExecuteChoice(string choice)
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

        private void CalculateMetricBMI() => Index = Kilograms / Centimeters * Centimeters;

        private void CalculateImperialBMI() => Index = Pounds / Inches * Inches;
        
        private void OutputBMI()
        {
            Console.WriteLine($"\n Your BMI Index is {Index}");
            if (Index < 18.50) 
            {
                Console.WriteLine("You are underweight");
            }
        }

        private void InputMetricValues()
        {
            Console.Write("please enter your weight in kg");
            string value = Console.ReadLine();
            Kilograms = Convert.ToDouble(value);

            Console.Write("please enter your height in centimeters");
            value = Console.ReadLine();
            Centimeters = Convert.ToDouble(value);
            Meters = Centimeters / 100;

        }

        private void InputImperialValues()
        {
            Console.Write("please enter your weight in Pounds");
            string value = Console.ReadLine();
            Pounds = Convert.ToDouble(value);

            Console.Write("please enter your height in Inches");
            value = Console.ReadLine();
            Inches = Convert.ToDouble(value);
        }

        public void OutputMessage()
        {
        }
    }
}



