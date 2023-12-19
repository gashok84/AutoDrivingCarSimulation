using AutoDrivingCarSimulation;

public static class Program
{
   public static void Main()
    {
       
        int fieldWidth = 10;
        int fieldHeight = 10;
        Car car = new Car(1, 2, 'N', fieldWidth - 1, fieldHeight - 1);
        string commands = "FFRFFFRRLF";

        foreach (char command in commands)
        {
            switch (command)
            {
                case 'F':
                    car.MoveForward();
                    break;
                case 'B':
                    car.MoveBackward();
                    break;
                case 'L':
                    car.RotateLeft();
                    break;
                case 'R':
                    car.RotateRight();
                    break;
                default:                  
                    break;
            }
        }

        Console.WriteLine($"{car.X} {car.Y} {car.Direction}");
    }
}
