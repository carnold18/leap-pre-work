using System;
using System.Collections.Generic;
using System.Text;

namespace EssentialTraining
{
    public class FlowControl
    {
        // Method 1-4 are useful methods when returning 1 of 2 things, either / or

        // Method 1 - Ternary expression based on a condition, same as if / else statement
        public bool IsYourFavoriteColorGreen(string color)
        {
            return (color.ToLower() == "green") ? true : false;
        }
        // Method 2
        public bool IsYourFavoriteColorRed(string color)
        {
            if (color.ToLower() == "red") return true;
            return false;
        }
        // Method 3 - If / Else statement
        public bool IsYourFavoriteColorBlue(string color)
        {
            if (color.ToLower() == "blue")
            {
                return true;
            } else
            {
                return false;
            }
        }
        // Method 4
        public bool IsYourFavoriteColorYellow(string color)
        {
            return (color.ToLower() == "yellow");
        }
        // Method 5 - if statements
        public string PrimarayOrSecondary(string color)
        {
            var result = "";
            if (color.ToLower() == "red")
            {
                result = "Primary";
            } else if (color.ToLower() == "blue")
            {
                result = "Primary";
            } else if (color.ToLower() == "yellow")
            {
                result = "Primary";
            } else
            {
                result = "Secondary";
            }
            return result;
        }
        // Method 6 - switch statements
        public string SecondaryOrPrimary(string color)
        {
            // explicitly declare this variable using its type
            string result;

            // can also declare this variable implcitly using var and assigning it to its type
            // this works the same as above
            // var result = "";

            switch(color.ToLower())
            {
                case "red":
                    result = "Primary";
                    // it is possible to place multiple statements here
                    // a break is needed at the end though to tell the program to 
                    // move into the next case OR exit the switch statement
                    break;
                case "blue":
                    result = "Primary";
                    break;
                case "yellow":
                    result = "Primary";
                    break;
                default:
                    result = "Secondary";
                    break;
            }
            return result;
        }
    }
}
