using System.Numerics;

namespace MathPlus
{
    internal class Vector
    {
        public static Vector3 ConvertToV3(Vector2 vector2, float z)
        {
            return new Vector3(vector2.X, vector2.Y, z);
        }
        public static Vector4 ConvertToV4(Vector3 vector3, float w)
        {
            return new Vector4(vector3.X, vector3.Y, vector3.Z, w);
        }
    }
}
