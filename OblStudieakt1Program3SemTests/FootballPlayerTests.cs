using Microsoft.VisualStudio.TestTools.UnitTesting;
using OblStudieakt1Program3Sem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OblStudieakt1Program3Sem.Tests
{
    [TestClass()]
    public class FootballPlayerTests
    {
        [TestMethod()]
        public void ValidNameTest()
        {
            //Arrange
            FootballPlayer fp1 = new FootballPlayer();

            //Act
            fp1.Name = "Christian";

            //Assert
            Assert.AreEqual("Christian", fp1.Name);
        }

        [TestMethod()]
        public void NameTooShortTest()
        {
            //Arrange
            FootballPlayer fp1 = new FootballPlayer();

            //Act & Assert
            Assert.ThrowsException<ArgumentException>(() => fp1.Name = "Bo");
        }

        [TestMethod()]
        public void ValidShirtNumberTest()
        {
            //Arrange
            FootballPlayer fp1 = new FootballPlayer();

            //Act
            fp1.ShirtNumber = 23;

            //Assert
            Assert.AreEqual(23, fp1.ShirtNumber);
        }

        [TestMethod()]
        public void ShirtNumberTooHighTest()
        {
            //Arrange
            FootballPlayer fp1 = new FootballPlayer();
            
            //Act & Assert
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => fp1.ShirtNumber = 20000);
        }

        [TestMethod()]
        public void ShirtNumberTooLowTest()
        {
            //Arrange
            FootballPlayer fp1 = new FootballPlayer();

            //Act & Assert
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => fp1.ShirtNumber = 0);
        }

        [TestMethod()]
        public void ValidPriceTest()
        {
            //Arrange
            FootballPlayer fp1 = new FootballPlayer();

            //Act
            fp1.Price = 1000000.0;

            //Assert
            Assert.AreEqual(1000000.0, fp1.Price);
        }

        [TestMethod()]
        public void PriceOutOfRangeTest()
        {
            //Arrange
            FootballPlayer fp1 = new FootballPlayer();

            //Act & Assert
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => fp1.Price = -1000000.0);
        }

        [TestMethod()]
        public void GetIdTest()
        {
            //Arrange
            FootballPlayer fp1 = new FootballPlayer();

            //Act & Assert
            Assert.AreEqual(1, fp1.Id);
        }
    }
}