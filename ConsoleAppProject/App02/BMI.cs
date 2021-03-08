using System;
using ConsoleAppProject.Helpers;

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
        public const double UNDERWEIGHT = 18.5;
        public const double NORMAL = 24.9;
        public const double OVERWEIGHT = 29.9;
        public const double OBESE = 34.9;
        public const double CLASS2 = 39.9;
        public const double CLASS3 = 40.0;



        public const string Imperial = "Imperial";
        public const string METRIC = "Metric";

        public double Inches { get; set; }
        public double Kilograms { get; set; }
        public double Pounds { get; set; }
        public double Feet { get; set; }
        public double Stones { get; set; }
        public double Centimeters { get; set; }
        public double Meters { get; set; }

        public UnitSystems UnitSystems
        {
            get => default;
        }

        public double Index { get; set; }


        //all variables feet,inches,kg,stones,pounds

        /// <summary>
        /// This method displays the choices for the user
        /// </summary>
        /// <param name="prompt"></param>
        /// <returns></returns>
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

        /// <summary>
        /// This method runs the application
        /// </summary>
        public void Run()
        {
            ConsoleHelper.OutputHeading("BMI Calculator");
            string choice = SelectUnit("Please enter your choice");
            ExecuteChoice(choice);

        }

        /// <summary>
        /// Allows the user to select the unit
        /// </summary>
        /// <param name="prompt"></param>
        /// <returns></returns>
        private string SelectUnit(string prompt)
        {
            string choice = DisplayChoices(prompt);

            string unit = ExecuteChoice(choice);
            Console.WriteLine($" You have chosen {unit}");
            return unit;
        }
        
        /// <summary>
        /// Allows the user to execute the choices
        /// </summary>
        /// <param name="choice"></param>
        /// <returns></returns>
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

        /// <summary>
        /// This method calculates the Metric BMI
        /// </summary>
        private void CalculateMetricBMI() => Index = Kilograms / Centimeters * Centimeters;

        /// <summary>
        /// This method calculates the Imperial BMI
        /// </summary>
        private void CalculateImperialBMI() => Index = Pounds / Inches * Inches;

        /// <summary>
        /// This method outputs the BMI
        /// </summary>
        private void OutputBMI()
        {
            Console.WriteLine($"\n Your BMI Index is {Index}");
            if (Index < 18.50)
            {
                Console.WriteLine("You are underweight");


            }
            else if (Index >= 18.5 && Index <= 24.6)
            {
                Console.WriteLine("You are normal weight");
            }
            else if (Index >= 25.0 && Index <= 29.9)
            {
                Console.WriteLine("You are overweight");
            }
            else if (Index >= 30.0 && Index <= 34.9)
            {
                Console.WriteLine("You are obese type 1");
            }
            else if (Index >= 35.0 && Index <= 39.9)
            {
                Console.WriteLine("You are obese type 2");
            }
            else if (Index >= 40.0)
            {
                Console.WriteLine("You are obese type 3");
            }
        }

        /// <summary>
        /// This method allows the user to input Metric Values
        /// </summary>
        private void InputMetricValues()
        {

            Kilograms = ConsoleHelper.InputNumber(" please enter your weight in kg > ");

            Centimeters = ConsoleHelper.InputNumber(" please enter your height in Centimeters > ");
            Meters = Centimeters / 100;
        }

        /// <summary>
        /// This method allows the user to input Imperial Values
        /// </summary>
        private void InputImperialValues()
        {

            Pounds = ConsoleHelper.InputNumber(" please enter your weight in Pounds > ");

            Inches = ConsoleHelper.InputNumber(" please enter your height in Inches > ");
        }

        public void OutputMessage()
        {
        }

        public void CalculateIndex()
        {
            ConsoleHelper.OutputHeading("Body Mass Index Calculator");

            UnitSystems unit system = SelectUnit();

            if (UnitSystems == UnitSystems.Metric)
            {
                InputMetricDetails();
                CalculateMetricBMI();
            }
            else
            {
                InputImperialDetails();
                CalculateImperialBMI();
            }

            Console.WriteLine(GetHealthMessage());
            Console.WriteLine(GetBameMessage());

        }

    }
}



