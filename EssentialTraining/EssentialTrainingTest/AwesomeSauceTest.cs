using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using EssentialTraining;

namespace EssentialTrainingTest
{
    [TestClass]
    public class AwesomeSauceTest
    {
        [TestMethod]
        public void IsSauceAwesomeTest()
        {
            var testInstance = new AwesomeSauce();
            testInstance.Sauces.Add("Tabasco");
            testInstance.Sauces.Add("Cholula");
            testInstance.Sauces.Add("Trailer Trash");

            //expect true
            Assert.IsTrue(testInstance.IsSauceAwesome("TrailerTrash"));

            //expect false
            Assert.IsFalse(testInstance.IsSauceAwesome("ketchup"));
        }
    }
}
