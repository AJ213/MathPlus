using System.Numerics;
using System;

namespace MathPlus
{
    class Geometry
    {
        public static float AreaRectangle(float width, float length)
        {
            return width * length;
        }
        public static float AreaCircle(float radius)
        {
            return radius * radius * (float) Math.PI;
        }
    }
}
