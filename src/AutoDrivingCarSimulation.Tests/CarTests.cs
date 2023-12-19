
namespace AutoDrivingCarSimulation.Tests
{
    [TestClass]
    public class CarTests
    {
        [TestMethod]
        public void MoveForward_IncrementY_WhenFacingNorth()
        {
            // Arrange
            Car car = new Car(1, 2, 'N', 10, 10);

            // Act
            car.MoveForward();

            // Assert
            Assert.AreEqual(3, car.Y);
        }

        [TestMethod]
        public void MoveForward_IncrementX_WhenFacingEast()
        {
            // Arrange
            Car car = new Car(1, 2, 'E', 10, 10);

            // Act
            car.MoveForward();

            // Assert
            Assert.AreEqual(2, car.X);
        }

        [TestMethod]
        public void MoveForward_DecrementY_WhenFacingSouth()
        {
            // Arrange
            Car car = new Car(1, 2, 'S', 10, 10);

            // Act
            car.MoveForward();

            // Assert
            Assert.AreEqual(1, car.Y);
        }

        [TestMethod]
        public void MoveForward_DecrementX_WhenFacingWest()
        {
            // Arrange
            Car car = new Car(1, 2, 'W', 10, 10);

            // Act
            car.MoveForward();

            // Assert
            Assert.AreEqual(0, car.X);
        }

        [TestMethod]
        public void MoveForward_NotExceedBoundaries()
        {
            // Arrange
            Car car = new Car(0, 0, 'S', 10, 10);

            // Act
            car.MoveForward();

            // Assert
            Assert.AreEqual(0, car.Y);
        }

        [TestMethod]
        public void RotateLeft_ChangeDirectionToWest()
        {
            // Arrange
            Car car = new Car(1, 2, 'N', 10, 10);

            // Act
            car.RotateLeft();

            // Assert
            Assert.AreEqual('W', car.Direction);
        }

        [TestMethod]
        public void RotateRight_ChangeDirectionToEast()
        {
            // Arrange
            Car car = new Car(1, 2, 'N', 10, 10);

            // Act
            car.RotateRight();

            // Assert
            Assert.AreEqual('E', car.Direction);
        }
    }
}
