using System;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// Please describe the main features of this App
    /// This app converts distances by other distances
    /// Hassan Nisar
    /// Student Name version 0.1
    /// Hassan Nisar
    public class DistanceConverter
    {
        public const int FEET_IN_MILES = 5200;

        public const int MILES_IN_FEET = 5200;

        public const int MILES_IN_METRES = 5200;

        private double miles;
       
        private double feet;
        
        /// <summary>
        /// This method will run all the method that are listed below
        /// </summary>
        public void Run()
        {
            OutputHeading();
            InputMiles();
            CalculateFeet();
            OutputFeet();
            InputFeet();
            CalculateMiles();
            OutputMiles();
            CalculateMeters();
            OutputMeters();
            InputMeters();



        }
        
        /// <summary>
        /// Prompt the user to enter the distance in miles
        /// Input the miles as a double number
        /// </summary>
        private void InputMiles()
        {
            Console.Write("Please enter the number of miles >");
            string value = Console.ReadLine();
            miles = Convert.ToDouble(value);

        }
        
        /// <summary>
        /// Prompt the user to enter the distance in feet
        /// Input the miles as a double number
        /// </summary> 
        private void CalculateFeet()
        {
            feet = miles * 5280;
        }

        /// <summary>
        /// Prompt the app to output the distance in feet
        /// </summary>
        private void OutputFeet()
        {
            Console.WriteLine(miles + " miles is " + feet + " feet ");
        }

        public void ConvertMilesToFeet()
        {
            OutputHeading();
            InputMiles();

            feet = miles * FEET_IN_MILES;

            OutputFeet();
        }

        private void InputFeet()
        {
            Console.Write("Please enter the number of feet >");
            string value = Console.ReadLine();
            feet = Convert.ToDouble(value);

        }

        private void CalculateMiles()
        {
            miles = feet / 5280;
        }

        private void OutputMiles()
        {
            Console.WriteLine(feet + " feet is " + miles + " miles ");
        }

        public void ConvertFeetToMiles()
        {
            OutputHeading();
            InputMiles();

            miles = feet / MILES_IN_FEET;

            OutputFeet();
        }

        private void InputMeters()
        {
            Console.Write("Please enter the number of meters >");
            string value = Console.ReadLine();
            feet = Convert.ToDouble(value);

        }

        private void CalculateMeters()
        {
            meters = miles / 0.00062137;
        }

        private void OutputMeters()
        {
            Console.WriteLine(miles + " miles is " + meters + " metres ");
        }

        public void ConvertMilesToMetres()
        {
            OutputHeading();
            InputMiles();

            meters = miles / METERS_IN_MILES;

            OutputFeet();
        }

        private void OutputHeading()
        {
            Console.WriteLine();
            Console.WriteLine(" -------------------------");
            Console.WriteLine("  Convert Miles to Feet   ");
            Console.WriteLine("    By Hassan Nisar       ");
            Console.WriteLine(" -------------------------");
            Console.WriteLine();
        }
    }
}
