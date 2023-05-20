using NUnit.Framework;
using System;

namespace Weather_Broadcast.Tests
{
    [TestFixture]
    public class DailyDetailsControlTests
    {
        [Test]
        public void SunRiseTimeValue_SetAndGet_Success()
        {
            // Arrange
            var control = new DailyDetailsControl();
            var expectedTime = "06:00 AM";

            // Act
            control.SunRiseTimeValue = expectedTime;
            var actualTime = control.SunRiseTimeValue;

            // Assert
            Assert.AreEqual(expectedTime, actualTime, "SunRiseTimeValue was not set or retrieved correctly.");
        }

        [Test]
        public void MoonSetTimeValue_SetAndGet_Success()
        {
            // Arrange
            var control = new DailyDetailsControl();
            var expectedTime = "10:30 PM";

            // Act
            control.MoonSetTimeValue = expectedTime;
            var actualTime = control.MoonSetTimeValue;

            // Assert
            Assert.AreEqual(expectedTime, actualTime, "MoonSetTimeValue was not set or retrieved correctly.");
        }

        [Test]
        public void HumidityValue_SetAndGet_Success()
        {
            // Arrange
            var control = new DailyDetailsControl();
            var expectedHumidity = "70%";

            // Act
            control.HumidityValue = expectedHumidity;
            var actualHumidity = control.HumidityValue;

            // Assert
            Assert.AreEqual(expectedHumidity, actualHumidity, "HumidityValue was not set or retrieved correctly.");
        }

        [Test]
        public void WindValue_SetAndGet_Success()
        {
            // Arrange
            var control = new DailyDetailsControl();
            var expectedWind = "20 KM/H";

            // Act
            control.WindValue = "20";
            var actualWind = control.WindValue;

            // Assert
            Assert.AreEqual(expectedWind, actualWind, "WindValue was not set or retrieved correctly.");
        }
    }
}
