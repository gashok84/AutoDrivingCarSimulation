using System;

namespace AutoDrivingCarSimulation
{
    public class Car
    {
        public int X { get; set; }
        public int Y { get; set; }
        public char Direction { get; set; }
        public int MaxX { get; set; }
        public int MaxY { get; set; }

        public Car(int x, int y, char direction, int maxX, int maxY)
        {
            X = x;
            Y = y;
            Direction = direction;
            MaxX = maxX;
            MaxY = maxY;
        }
        public void MoveForward()
        {
            // Move the car forward based on its direction, considering boundaries
           
            if (Direction == 'N' && Y < MaxY) Y++;
            else if (Direction == 'E' && X < MaxX) X++;
            else if (Direction == 'S' && Y > 0) Y--;
            else if (Direction == 'W' && X > 0) X--;
                      
        }

        public void MoveBackward()
        {
            // Move the car backward based on its direction, considering boundaries
            if (Direction == 'N' && Y > 0) Y--;
            else if (Direction == 'E' && X > 0) X--;
            else if (Direction == 'S' && Y < MaxY) Y++;
            else if (Direction == 'W' && X < MaxX) X++;
        }

        public void RotateLeft()
        {
            // Rotate the car 90 degrees to the left
            if (Direction == 'N') Direction = 'W';
            else if (Direction == 'W') Direction = 'S';
            else if (Direction == 'S') Direction = 'E';
            else if (Direction == 'E') Direction = 'N';
        }

        public void RotateRight()
        {
            // Rotate the car 90 degrees to the right
            if (Direction == 'N') Direction = 'E';
            else if (Direction == 'E') Direction = 'S';
            else if (Direction == 'S') Direction = 'W';
            else if (Direction == 'W') Direction = 'N';
        }
    }
}
