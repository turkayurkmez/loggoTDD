using FizzBuzz.Game;
using Xunit;

namespace FizzBuzz.Tests
{
    public class GameTests
    {
        [Fact]
        public void GameIsExist()
        {
            var game = new FizzBuzzGame();
            /*
             * 3 ve 3'ün katlarında Fizz
             * 5 ve 5               Buzz
             * Diğer sayılarda sayının kendisi döner.
             */    

           
        }
        [Fact]
        public void Given_3_Then_Return_Fizz()
        {
            //AAA
            //Arrange: hazırla
            //Act: Eyleme geç
            //Assert: Sonucu denetle

            //Arrange:
            var game = new FizzBuzzGame();
            //Act:
            var result = game.FizzBuzz(3);
            //Assert:
            Assert.Equal("Fizz", result);

        }


        [Fact]
        public void Given_5_Then_Return_Buzz()
        {
            //AAA
            //Arrange: hazırla
            //Act: Eyleme geç
            //Assert: Sonucu denetle

            //Arrange:
            var game = new FizzBuzzGame();
            //Act:
            var result = game.FizzBuzz(5);
            //Assert:
            Assert.Equal("Buzz", result);

        }


        [Fact]
        public void Given_15_Then_Return_Buzz()
        {
            //AAA
            //Arrange: hazırla
            //Act: Eyleme geç
            //Assert: Sonucu denetle

            //Arrange:
            var game = new FizzBuzzGame();
            //Act:
            var result = game.FizzBuzz(15);
            //Assert:
            Assert.Equal("FizzBuzz", result);

        }
        [Theory]
        [InlineData(15)]
        [InlineData(30)]
        [InlineData(60)]
        [InlineData(90)]
        public void Given_DivisibleBy3And5_Then_Return_FizzBuzz(int number)
        {
            //AAA
            //Arrange: hazırla
            //Act: Eyleme geç
            //Assert: Sonucu denetle

            //Arrange:
            var game = new FizzBuzzGame();
            //Act:
            var result = game.FizzBuzz(number);
            //Assert:
            Assert.Equal("FizzBuzz", result);

        }
        [Theory]
        [InlineData(7)]
        [InlineData(13)]
        [InlineData(16)]
        public void Given_Ordered_Number_Then_Return_Number(int number)
        {
            //AAA
            //Arrange: hazırla
            //Act: Eyleme geç
            //Assert: Sonucu denetle

            //Arrange:
            var game = new FizzBuzzGame();
            //Act:
            var result = game.FizzBuzz(number);
            //Assert:
            Assert.Equal(number.ToString(), result);
        }







    }
}