using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoDrivingCarSimulation
{
    public class Field
    {
        public int Width { get; }
        public int Height { get; }

        public Field(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public bool IsWithinBoundaries(int x, int y)
        {
            // Check if the coordinates are within the field boundaries
            return x >= 0 && x < Width && y >= 0 && y < Height;
        }
    }

}
