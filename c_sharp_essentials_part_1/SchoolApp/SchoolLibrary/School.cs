using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolLibrary
{
    public class School
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Number { get; set; }
        private string _twitterAddress;
        public string TwitterAddress
        {
            // make sure the twitter address starts with an @ sysmbol
            get { return _twitterAddress; }
            set
            {
                if (value.StartsWith("@"))
                {
                    _twitterAddress = value;
                } else
                {
                    throw new Exception("The twitter address must begin with @");
                }
            }

        }

        /* we can remove the SchoolLibrary from the beginning of these
        the grey is telling us it is not needed  */

        // namespaces exist to prevent class name collisions
        // namespaces are not required
        // namespaces exist purely to organize the code

       //  SchoolLibrary.Elementary.Volume volume;
       // SchoolLibrary.HighSchool.Volume volume2;

        public School()
        {
            Name = "Untitled School";
            Number = "555-1234";
        }

        public School(string SchoolName, string SchoolPhoneNumber)
        {
            Name = SchoolName;
            Number = SchoolPhoneNumber;
        }

        // Function overloading 
        // typical function declaration
        //public float AverageThreeScores(float a, float b, float c)
        //{
        //    var result = (a + b + c) / 3;
        //    return result;
        //}

        // function bodied expression is the same as above
        public static float AverageThreeScores(float a, float b, float c) => (a + b + c) / 3;
        public static int AverageThreeScores(int a, int b, int c)
        {
            var result = (a + b + c) / 3;
            return result;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(Name);
            sb.AppendLine(Address);
            sb.Append(City);
            sb.Append(", ");
            sb.Append(State);
            sb.Append(Zip);
            return sb.ToString();
        }
    }
}
