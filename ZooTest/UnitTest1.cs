
using Program;

namespace ZooTests
{
    public class AnimalTests
    {
        [Fact]
        public void Eat_ShouldReturnEatingMessage()
        {
            // Arrange
            Animal lion = new Animal("Lion", 4, "Yellow");

            // Act
            string result = lion.Eat();

            // Assert
            Assert.Equal("Lion is eating.", result);
        }

        [Fact]
        public void Sleep_ShouldReturnSleepingMessage()
        {
            // Arrange
            Animal elephant = new Animal("Elephant", 4, "Gray");

            // Act
            string result = elephant.Sleep();

            // Assert
            Assert.Equal("Elephant is sleeping.", result);
        }
    }
}
