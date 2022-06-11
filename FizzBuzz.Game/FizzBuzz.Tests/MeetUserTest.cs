using FizzBuzz.Game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace FizzBuzz.Tests
{
    public class MeetUserTest
    {
        [Fact]
        public void GetGreeting_12_ReturnsGoodMorning()
        {
            // Arrange
            var meetUser = new MeetUser(new TestTimeManager());

            // Act
            var result = meetUser.GetGreeting();

            // Assert
            Assert.Equal("Günaydın", result);
        }

        [Theory]
        [InlineData(13)]
        [InlineData(17)]
        [InlineData(15)]

        public void Afternoon_test(int hour)
        {
            // Arrange
         
            var afterNoon = new TestTimeManager();
            afterNoon.SetCurrentTime(new DateTime(2022, 6, 11, hour, 0, 0));
            var meetUser = new MeetUser(afterNoon);

            // Act
            var result = meetUser.GetGreeting();

            // Assert
            Assert.Equal("İyi günler", result);
        }
    }
}
