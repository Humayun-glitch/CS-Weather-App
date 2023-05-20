using NUnit.Framework;
using System.Collections.Generic;

namespace Weather_Broadcast.Tests
{
    [TestFixture]
    public class ConstantTests
    {
        [Test]
        public void MapOfCityNameAndID_ContainsExpectedCities()
        {
            // Arrange
            var expectedCities = new Dictionary<string, int>()
            {
                { "Calgary", 5913490 },
                { "Toronto", 6087824 },
                { "Vancouver", 6090785 },
                { "Saskatoon", 6141256 },
                { "Quebec", 6325494 },
                { "Airdrie", 5882799 },
                { "Medicine Hat", 6071618},
                { "Banff", 5892532 },
                { "California", 4350049 },
                { "Florida", 3851244 }
            };

            // Act
            var actualCities = Constant.MapOfCityNameAndID;

            // Assert
            CollectionAssert.AreEqual(expectedCities, actualCities, "The MapOfCityNameAndID dictionary does not contain the expected cities.");
        }

        [Test]
        public void API_KEY_IsNotEmpty()
        {
            // Act
            var apiKey = Constant.API_KEY;

            // Assert
            Assert.IsFalse(string.IsNullOrEmpty(apiKey), "The API_KEY constant should not be empty or null.");
        }

        [Test]
        public void FETCH_WEATHER_URL_IsValid()
        {
            // Arrange
            var expectedUrlStart = "http://api.apixu.com/v1/forecast.json?key=";

            // Act
            var url = Constant.FETCH_WEATHER_URL;

            // Assert
            StringAssert.StartsWith(expectedUrlStart, url, "FETCH_WEATHER_URL does not have the expected format.");
        }

        [Test]
        public void NUMBER_OF_WEATHER_FORECAST_DAYS_IsPositive()
        {
            // Act
            var numberOfDays = Constant.NUMBER_OF_WEATHER_FORECAST_DAYS;

            // Assert
            Assert.IsTrue(numberOfDays > 0, "NUMBER_OF_WEATHER_FORECAST_DAYS should be a positive value.");
        }
    }
}
