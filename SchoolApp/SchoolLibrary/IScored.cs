using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolLibrary
{
    public interface IScored
    {
        // no logic or code is meant to be written here
        // start all interfaces with I
        // define properties or methods that we want to appear on the objects that use this interface 
        // an interface is entirely for structure, not logic
        // a class can only inherit from one class but interfaces can be used to enact behaviors across classes
        // interfaces allow for setting up common behaviors / structures within code

        float Score { get; set; }
        float MaximumScore { get; set; }
    }
}
