using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sandbox;

namespace CarUnitTest
{
    [TestClass]
    public class CarTest
    {
        private Car c;
        
        [TestMethod]
        public void TestTooShortRegnrException()
        {
            //Arrange
            c = new Car("Skoda");

            //Act og Assert
            Assert.ThrowsException<TooShortRegnrException>(

                () =>
            {
                c.Regnr = "FF1234";
            }
                );
        }

        [TestMethod]
        public void TestCarModel()
        {
            //Arrange
            string model = "Skoda";
            Car c = new Car(model);
            //Act
            string actualModel = c.Model;

            //Assert
            Assert.AreEqual(model, actualModel);
        }
    }
}
