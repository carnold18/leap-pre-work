using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EssentialTraining;

namespace EssentialTrainingTests
{
    [TestClass]
    public class AwesomeSauceTest
    {
        [TestMethod]
        public void IsSauceAwesomeTest()
        {
            var testInstance = new AwesomeSauce();
            testInstance.Sauces.Add("Tobasco");
            testInstance.Sauces.Add("Cholula");
            testInstance.Sauces.Add("Trailer Trash");
            testInstance.Sauces.Add("Crystal");

            Assert.IsTrue(testInstance.IsSauceAwesome("Cholula"));
            Assert.IsFalse(testInstance.IsSauceAwesome("Mayo"));
        }
    }
}
