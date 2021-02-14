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
        private double miles;
       
        private double feet;
        
        /// <summary>
        /// 
        /// </summary>
        public void Run()
        {
            InputMiles();
            CalculateFeet();
            OutputFeet();
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

        }

        /// <summary>
        /// Prompt the app to output the distance in feet
        /// </summary>
        private void OutputFeet()
        {
        
        }
    }
}
