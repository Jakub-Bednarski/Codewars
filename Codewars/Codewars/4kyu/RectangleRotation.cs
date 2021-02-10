using System;

namespace Codewars._4kyu
{
    /// <summary>
    /// https://www.codewars.com/kata/5886e082a836a691340000c3/csharp
    /// </summary>
    public class RectangleRotation
    {
        public int RectangleRotationCount(int a, int b)
        {
            double sqrt2 = Math.Sqrt(2);
            int firstSide = (int)((a / 2) / (sqrt2 / 2));
            int secoundSide = (int)((b / 2) / (sqrt2 / 2));

            if ((firstSide % 2 == 0 && secoundSide % 2 == 0) || (firstSide % 2 == 1 && secoundSide % 2 == 1))
            {
                return firstSide * secoundSide + (firstSide + 1) * (secoundSide + 1);
            }

            return (firstSide + 1) * (secoundSide) + firstSide * (secoundSide + 1);
        }
    }
}
