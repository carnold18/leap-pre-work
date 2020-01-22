using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolLibrary
{
    public class Student : Person
    {
        public enum GradeLevels { Freshman, Sophomore, Junior, Senior }
        public GradeLevels GradeLevel { get; set; }
        public override float ComputeGradeAverage()
        {
            return 4.0f;
        }

        // the method below does the same as not passing an override method here at all
        // base is the Person abstract class
        // this is taking the Person SendMessage method and implementing it here

        //public override string SendMessage(string message)
        //{
        //    return base.SendMessage(message);
        //}

        public override string SendMessage(string message)
        {
            var original = base.SendMessage(message);
            var sb = new StringBuilder(original);
            sb.AppendLine("This message is private and confidential.");
            return sb.ToString();
        }
    }
}
