using System;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// This class offers methods for converting a given
    /// distance measured in miles to the equivalent
    /// distance measured in feet
    /// </summary>
    /// <author>
    /// Michael Waterhouse version 0.1
    /// </author>
    public class DistanceConverter
    {
        public const int FEET_IN_MILES = 5280;

        private double miles;

        private double feet;

        /// <summary>
        /// 
        /// </summary>
        public void Run()
        {
            OutputHeading();
            InputMiles();
            CalculateFeet();
            OutputFeet();
        }

        private void OutputHeading()
        {
            Console.WriteLine("\n-------------------------------------");
            Console.WriteLine("          Convert Miles to Feet       ");
            Console.WriteLine("          Michael Waterhouse          ");
            Console.WriteLine("-------------------------------------\n");
        }

        /// <summary>
        /// Primpt user to enter the distance in miles
        /// Input the miles as a double number 
        /// </summary>
        private void InputMiles()
        {
            Console.Write("Please enter the number of miles >");
            string value = Console.ReadLine();
            miles = Convert.ToDouble(value);
        }

        private void CalculateFeet()
        {
            feet = miles * 5280;
        }

        private void OutputFeet()
        {
            Console.WriteLine(miles + "miles is " + feet + "feet!");
        }
    }
}
