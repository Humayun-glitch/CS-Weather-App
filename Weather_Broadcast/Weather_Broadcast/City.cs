using NUnit.Framework;
using Weather_Broadcast;

namespace Weather_Broadcast_Tests
{
    [TestFixture]
    public class CityTests
    {
        [Test]
        public void CityConstructor_WithName_SetsName()
        {
            // Arrange
            string cityName = "TestCity";

            // Act
            City city = new City(cityName);

            // Assert
            Assert.AreEqual(cityName, city.Name);
        }

        [TestCase("TestCity", 1)]
        [TestCase("AnotherCity", 2)]
        [TestCase("UnknownCity", -1)]
        public void GetCityIDFromCityName_WithValidOrInvalidCityName_ReturnsExpectedResult(string cityName, int expectedCityID)
        {
            // Arrange
            City city = new City(cityName);

            // Act
            int cityID = city.GetCityIDFromCityName();

            // Assert
            Assert.AreEqual(expectedCityID, cityID);
        }
    }
}