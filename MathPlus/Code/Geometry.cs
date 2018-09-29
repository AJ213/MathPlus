using System.Numerics;
using System;

namespace MathPlus
{
    class Geometry
    {
        public static double AreaRectangle(double baseValue, double height)
        {
            return baseValue * height;
        }
        public static double AreaSquare(double length)
        {
            return Math.Pow(length, 2);
        }
        public static double AreaParallelogram(double baseValue, double height)
        {
            return AreaRectangle(baseValue, height);
        }
        public static double AreaRightTriangle(double baseValue, double height)
        {
            return AreaRectangle(baseValue, height) / 2;
        }
        public static double AreaRhombus(double baseA, double baseB)
        {
            return AreaRightTriangle(baseA, baseB);
        }
        public static double AreaKite(double baseA, double baseB)
        {
            return AreaRightTriangle(baseA, baseB);
        }
        public static double AreaTrapezoid(double baseA, double baseB, double height)
        {
            return (baseA + baseB) * height / 2;
        }
        public static double AreaRegularPolygon(double apothem, double perimeter)
        {
            return apothem * perimeter / 2;
        }

        public static double AreaCircle(double radius)
        {
            return Math.Pow(radius, 2) * Math.PI;
        }
        public static double AreaElipse(double radiusA, double radiusB)
        {
            return radiusA * radiusB * Math.PI;
        }
        public static double AreaSector(double angle, double radius)
        {
            return angle / 2 * Math.Pow(radius, 2);
        }
    }
}
