using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolLibrary
{
    public abstract class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        // an abstract method MUST be used in all subclasses
        public abstract float ComputeGradeAverage();
        
        // create a virtual method in the abstract class that can be used in subclasses or not
        // this can be used as is or overriden by another in the subclass
        // the purpose of a virtual method is to take the base implementation and change it slightly 
        // to fit the needs of the class on which it is called
        public virtual string SendMessage( string message)
        {
            var sb = new StringBuilder();
            var timeStamp = string.Format("Sent on {0:D} at {0:t}", DateTime.Now);
            sb.AppendLine(timeStamp);
            sb.AppendLine("");
            sb.AppendLine("Dear " + FirstName + ",");
            sb.AppendLine(message);
            // do not forget to convert the sb to type string when returning from the method
            return sb.ToString();
        }
    }
}
