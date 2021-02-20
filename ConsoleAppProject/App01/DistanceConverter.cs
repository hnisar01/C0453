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
        public const int FEET_IN_MILES = 5280;

        public const double METERS_IN_MILES = 1600;

        private const double FEET_IN_METERS = 3.29084;

        private const string FEET = "feet";

        private const string METERS = "meters";

        private const string MILES = "miles";

        private double fromDistance;
        private double toDistance;

        private string fromUnit;
        private string toUnit;

        public double METERS_IN_FEET { get; private set; }
        public double MILES_IN_METERS { get; private set; }

        public DistanceConverter()
        {
            fromUnit = MILES;
            toUnit = FEET;
        }
            

        /// <summary>
        /// This method will run all the method that are listed below
        /// </summary>

        public void Run()
        {
            fromUnit = SelectUnit(" Please select the from distance unit > ");
            toUnit = SelectUnit(" Please select  the to distance unit");
            
            OutputHeading();

            Console.WriteLine($"\n Converting {fromUnit} to {toUnit}");

            fromDistance = InputDistance($"Please enter the number of {fromUnit}  > ");

            CalculatetoDistance();

            OutputtoDistance();
        }

        private void CalculatetoDistance()
        {
            if (fromUnit == MILES && toUnit == FEET)
            {
                toDistance = fromDistance * FEET_IN_MILES;
            }
            else if (fromUnit == FEET && toUnit == MILES)
            {
                toDistance = fromDistance / FEET_IN_MILES;
            }
            else if (fromUnit == MILES && toUnit == METERS)
            {
                toDistance = fromDistance / MILES_IN_METERS;
            }
            else if (fromUnit == METERS && toUnit == MILES)
            {
                toDistance = fromDistance / METERS_IN_MILES;
            }
            else if (fromUnit == FEET && toUnit == METERS)
            {
                toDistance = fromDistance / FEET_IN_METERS;
            }
            else if (fromUnit == METERS && toUnit == FEET)
            {
                toDistance = fromDistance / METERS_IN_FEET;
            }
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
                return FEET;
            }
            else if (choice == "2")
            {
                return METERS;
            }
            else if (choice.Equals("3"))
            {
                return MILES;
            }

            return null;
        }

        private static string DisplayChoices(string prompt)
        {
            Console.WriteLine();
            Console.WriteLine($" 1. {FEET}");
            Console.WriteLine($" 2. {METERS}");
            Console.WriteLine($" 3. {MILES}");
            Console.WriteLine();

            Console.Write(prompt);
            string choice = Console.ReadLine();
            return choice;
        }

        /// <summary>
        /// Prompt the user to enter the distance in miles
        /// Input the miles as a double number
        /// </summary>
        private double InputDistance(string prompt)
        {
            Console.Write(prompt);
            string value = Console.ReadLine();
            return Convert.ToDouble(value);

        }
        



        /// <summary>
        /// Prompt the app to output the distance in feet
        /// </summary>
        private void OutputtoDistance()
            
        {
            Console.WriteLine($"\n {fromDistance} {fromUnit}" +
                $" is {toDistance} {toUnit}!\n");
        }
        
        private void OutputHeading()
        {
            Console.WriteLine();
            Console.WriteLine(" -------------------------");
            Console.WriteLine("   Convert Distances      ");
            Console.WriteLine("    By Hassan Nisar       ");
            Console.WriteLine(" -------------------------");
        }
    }
}
