using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolLibrary
{
    public class ScienceExperiment : IScored
    // can inherit from both an interface and a parent class
    // separate the items by a comma, placing the class first
    // cannot inherit from multiple classes
    // can implement multiple interfaces
    {
        public string Hypothesis { get; set; }
        public string Materials { get; set; }
        public string Method { get; set; }
        public string Conclusion { get; set; }
        public float Score { get; set; }
        public float MaximumScore { get; set; }
    }
}
