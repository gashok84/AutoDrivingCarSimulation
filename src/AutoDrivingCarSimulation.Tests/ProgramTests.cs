
using Microsoft.VisualStudio.TestPlatform.Utilities;

namespace AutoDrivingCarSimulation.Tests
{
    [TestClass]
    public class ProgramTests
    {

        [TestMethod]
        public void MainPositionAndDirection_WhenExecutingCommands()
        {
            try
            {
                // Arrange
                int width = 10;
                int height = 10;
                Car car = new Car(1, 2, 'N', width - 1, height - 1);
                string commands = "FFRFFFRRLF";
                string expectedOutput = "4 3 S";
                string actualOutput = "";
                // Act
                using (StringWriter sw = new StringWriter())
                {
                    Console.SetOut(sw);

                    // Execute the commands on the car
                    foreach (char command in commands)
                    {
                        if (command == 'F')
                            car.MoveForward();
                        else if (command == 'L')
                            car.RotateLeft(); // Simulate left rotation
                        else if (command == 'R')
                            car.RotateRight(); // Simulate right rotation
                    }

                    // Print the final position and direction
                    Console.WriteLine($"{car.X} {car.Y} {car.Direction}");


                    actualOutput = sw.ToString().Trim();


                }
                // Assert
                Assert.AreEqual(expectedOutput, actualOutput);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
                throw;
            }
        }

        [TestMethod]
        public void MainPositionAndDirection_WhenMovingInsideBoundaries()
        {
            try
            {
                // Arrange
                int width = 10;
                int height = 10;
                Car car = new Car(1, 2, 'N', width - 1, height - 1);
                string commands = "FFRFFFRRLF";
                string expectedOutput = "4 3 S";

                // Act
                using (StringWriter sw = new StringWriter())
                {
                    Console.SetOut(sw);

                    // Execute the commands on the car
                    foreach (char command in commands)
                    {
                        if (command == 'F')
                            car.MoveForward();
                        else if (command == 'L')
                            car.RotateLeft(); // Simulate left rotation
                        else if (command == 'R')
                            car.RotateRight(); // Simulate right rotation

                    }

                    // Print the final position and direction
                    Console.WriteLine($"{car.X} {car.Y} {car.Direction}");

                    string actualOutput = sw.ToString().Trim();

                    // Assert
                    Assert.AreEqual(expectedOutput, actualOutput);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
                throw;
            }
        }


        [TestMethod]

        public void MainPositionAndDirection_WhenMovingOutsideBoundaries()
        {
            // Arrange
            int width = 5; // Adjust the width to a smaller value for testing boundary conditions
            int height = 5;
            Car car = new Car(1, 2, 'N', width - 1, height - 1);
            string commands = "FFRFFFRRLF";
            string expectedOutput = "4 3 S"; // Expecting the car to stay at the bottom boundary facing South

            // ...

            // Act
            StringWriter sw = new StringWriter();
            TextWriter originalOut = Console.Out;

            try
            {
                Console.SetOut(sw);

                // Execute the commands on the car
                foreach (char command in commands)
                {
                    if (command == 'F')
                        car.MoveForward();
                    else if (command == 'L')
                        car.RotateLeft();
                    else if (command == 'R')
                        car.RotateRight();


                    Console.WriteLine($"Intermediate: {car.X} {car.Y} {car.Direction} (Command: {command})");
                }

                // Print the final position and direction
                Console.WriteLine($"Final: {car.X} {car.Y} {car.Direction}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
                throw;
            }
            finally
            {
                Console.SetOut(originalOut);
            }
            string swOutput = sw.ToString();
            // string actualOutput = sw.ToString().Split('\n').LastOrDefault()?.Trim() ?? string.Empty;  // Get the last line (final output)
            Console.WriteLine($"actualOutput : {swOutput}");

            Assert.IsTrue(swOutput.Contains(expectedOutput));
            // Assert

        }
    }

}


