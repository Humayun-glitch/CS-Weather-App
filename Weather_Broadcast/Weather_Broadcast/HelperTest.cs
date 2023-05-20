using NUnit.Framework;
using System.IO;

namespace Weather_Broadcast.Tests
{
    [TestFixture]
    public class HelperTests
    {
        [Test]
        public void GetListOfCityNames_ReturnsNonEmptyArray()
        {
            // Act
            var cityNames = Helper.GetListOfCityNames();

            // Assert
            Assert.IsNotNull(cityNames, "The GetListOfCityNames method should not return a null array.");
            Assert.IsNotEmpty(cityNames, "The GetListOfCityNames method should return a non-empty array.");
        }

        [Test]
        public void ConvertFahrenheitToCelsius_ConvertsCorrectly()
        {
            // Arrange
            double fahrenheitTemp = 32.0;
            string expectedCelsiusTemp = "0";

            // Act
            string actualCelsiusTemp = Helper.ConvertFahrenheitToCelsius(fahrenheitTemp);

            // Assert
            Assert.AreEqual(expectedCelsiusTemp, actualCelsiusTemp, "The ConvertFahrenheitToCelsius method did not convert the temperature correctly.");
        }

        [Test]
        public void ConvertCelsiusToFahrenheit_ConvertsCorrectly()
        {
            // Arrange
            double celsiusTemp = 0.0;
            string expectedFahrenheitTemp = "32";

            // Act
            string actualFahrenheitTemp = Helper.ConvertCelsiusToFahrenheit(celsiusTemp);

            // Assert
            Assert.AreEqual(expectedFahrenheitTemp, actualFahrenheitTemp, "The ConvertCelsiusToFahrenheit method did not convert the temperature correctly.");
        }
    }
}
