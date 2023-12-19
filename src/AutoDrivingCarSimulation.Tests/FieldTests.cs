using AutoDrivingCarSimulation;


namespace AutoDrivingCarSimulation.Tests
{
    [TestClass]
    public class FieldTests
    {
        [TestMethod]
        public void IsWithinBoundaries_ReturnTrue_WhenCoordinatesAreWithinBoundaries()
        {
            // Arrange
            Field field = new Field(10, 10);

            // Act
            bool result = field.IsWithinBoundaries(5, 5);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsWithinBoundaries_ReturnTrue_WhenCoordinatesAreAtTheTopLeftCorner()
        {
            // Arrange
            Field field = new Field(10, 10);

            // Act
            bool result = field.IsWithinBoundaries(0, 0);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsWithinBoundaries_ReturnTrue_WhenCoordinatesAreAtTheBottomRightCorner()
        {
            // Arrange
            Field field = new Field(10, 10);

            // Act
            bool result = field.IsWithinBoundaries(9, 9);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsWithinBoundaries_ReturnFalse_WhenXCoordinateExceedsWidth()
        {
            // Arrange
            Field field = new Field(10, 10);

            // Act
            bool result = field.IsWithinBoundaries(11, 5);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsWithinBoundaries_ReturnFalse_WhenYCoordinateExceedsHeight()
        {
            // Arrange
            Field field = new Field(10, 10);

            // Act
            bool result = field.IsWithinBoundaries(5, 11);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsWithinBoundaries_ReturnFalse_WhenCoordinatesAreNegative()
        {
            // Arrange
            Field field = new Field(10, 10);

            // Act
            bool result = field.IsWithinBoundaries(-1, 5);

            // Assert
            Assert.IsFalse(result);
        }

    }
}
