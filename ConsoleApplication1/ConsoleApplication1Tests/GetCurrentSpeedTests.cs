using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Tests
{
    [TestClass()]
    public class GetCurrentSpeedTests
    {
        [TestMethod()]
        public void DistanceInText()
        {
            //Arrange
            GetCurrentSpeed cal = new GetCurrentSpeed();
            //Actual
            var actual = cal.SpeedCalc("trettiofem");
            //Assert
        }

        [TestMethod()]
        public void SpeedCalcTest()
        {
            //Arrange
            GetCurrentSpeed cal = new GetCurrentSpeed();
            //Actual

            //Assert
        }
        [TestMethod()]
        public void SpeedCalcWithSpace()
        {
            //Arrange
            GetCurrentSpeed cal = new GetCurrentSpeed();
            //Act
            var actual = cal.SpeedCalc(" 5");
            var expected = 45;
            //Assert
            Assert.AreEqual(expected, actual, "Space + number test Correct");
        }
    }
}