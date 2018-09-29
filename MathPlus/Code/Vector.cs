using System.Numerics;

namespace MathPlus
{
    internal class Vector
    {
        public static Vector2 ConvertToV2(float x, float y)
        {
            return new Vector2(x, y);
        }
        public static Vector3 ConvertToV3(float x, float y, float z)
        {
            return new Vector3(x, y, z);
        }
        public static Vector3 ConvertToV3(Vector2 vector2, float z)
        {
            return new Vector3(vector2.X, vector2.Y, z);
        }
        public static Vector4 ConvertToV4(float x, float y, float z, float w)
        {
            return new Vector4(x, y , z, w);
        }
        public static Vector4 ConvertToV4(Vector2 vector2, float z, float w)
        {
            return new Vector4(vector2.X, vector2.Y, z, w);
        }
        public static Vector4 ConvertToV4(Vector3 vector3, float w)
        {
            return new Vector4(vector3.X, vector3.Y, vector3.Z, w);
        }

        public static float FindSlope(Vector2 pointA, Vector2 pointB)
        {
            return (pointA.Y - pointB.Y) / (pointA.X - pointB.X);
        }
        public static float FindYIntercept(float slope, Vector2 point)
        {
            return point.Y - (slope * point.X);
        }
    }
}
