using System;

namespace Clocktest
{
    public class Program
    {
        public string Square = "█";
        // somehow implement this square as output for the algorithm below
        public void Main(int startX, int y, int deltaX, int deltaY)
        {
            var deltaYPerPixel = deltaY / deltaX;
            /* var steepAngle = false;
             * if (deltaY > deltaX)
             * { steepAngle = true; }
             */
            var correctY = y;
            for (int x = startX; x < startX + deltaX; x++)
            {
                drawPixel(x, y);
                correctY += deltaYPerPixel;
                if (correctY - y > 0.5) y++;

            }
            
        }
    }
}
