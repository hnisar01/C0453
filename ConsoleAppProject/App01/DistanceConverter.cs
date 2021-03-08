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

        public const double FEET_IN_METERS = 3.29084;

        public const string FEET = "feet";

        public const string METERS = "meters";

        public const string MILES = "miles";

        public double FromDistance { get; set; }
        public double ToDistance { get; set; }

        public string FromUnit { get; set; }
        public string ToUnit { get; set; }

        public double METERS_IN_FEET { get; private set; }
        public double MILES_IN_METERS { get; private set; }

        public DistanceConverter()
        {
            FromUnit = MILES;
            ToUnit = FEET;
        }
            

        /// <summary>
        /// This method will run all the method that are listed below
        /// </summary>
        public void Run()
        {
            FromUnit = SelectUnit(" Please select the from distance unit > ");
            ToUnit = SelectUnit(" Please select  the to distance unit");
            
            OutputHeading();

            Console.WriteLine($"\n Converting {FromUnit} to {ToUnit}");

            FromDistance = InputDistance($"Please enter the number of {FromUnit}  > ");

            CalculatetoDistance();

            OutputtoDistance();
        }

        /// <summary>
        /// This method is to calculate the the distance conversion
        /// </summary>
        public void CalculatetoDistance()
        {
            if (FromUnit == MILES && ToUnit == FEET)
            {
                ToDistance = FromDistance * FEET_IN_MILES;
            }
            else if (FromUnit == FEET && ToUnit == MILES)
            {
                ToDistance = FromDistance / FEET_IN_MILES;
            }
            else if (FromUnit == MILES && ToUnit == METERS)
            {
                ToDistance = FromDistance * METERS_IN_MILES;
            }
            else if (FromUnit == METERS && ToUnit == MILES)
            {
                ToDistance = FromDistance / METERS_IN_MILES;
            }
            else if (FromUnit == FEET && ToUnit == METERS)
            {
                ToDistance = FromDistance / FEET_IN_METERS;
            }
            else if (FromUnit == METERS && ToUnit == FEET)
            {
                ToDistance = FromDistance / METERS_IN_FEET;
            }
        }

        /// <summary>
        /// This method helps the user to choose the unit
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
        /// This method exectutes the choice the user decides to utilise
        /// </summary>
        /// <param name="choice"></param>
        /// <returns></returns>
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

        /// <summary>
        /// This method displays the choices for the user
        /// </summary>
        /// <param name="prompt"></param>
        /// <returns></returns>
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
            Console.WriteLine($"\n {FromDistance} {FromUnit}" +
                $" is {ToDistance:0.00} {ToUnit:0.00}!\n");

            
        }
        
        /// <summary>
        /// This method displays the heading for the user
        /// </summary>
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
