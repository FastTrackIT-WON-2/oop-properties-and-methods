using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesAndMethods
{
    public class Rectangle
    {
        public Rectangle(Point topLeft, int width, int height)
            : this(topLeft, new Point(topLeft.X + width, topLeft.Y + height), width, height)
        {
        }

        public Rectangle(Point topLeft, Point bottomRight)
            : this (topLeft, bottomRight, width: Math.Abs(bottomRight.X - topLeft.X), height: Math.Abs(bottomRight.Y - topLeft.Y))
        {
        }

        private Rectangle(Point topLeft, Point bottomRight, int width, int height)
        {
            TopLeft = topLeft;
            BottomRight = bottomRight;
            Width = width;
            Height = height;
        }

        public Point TopLeft { get; }

        public Point BottomRight { get; }

        public int Width { get; }

        public int Height { get; }
    }
}
