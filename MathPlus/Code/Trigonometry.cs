using System;

namespace MathPlus.Code
{
    class Trigonometry
    {
        public static double DegToRad(double angle)
        {
            return (angle * (Math.PI / 180.0f));
        }

        public static double AreaTriangleSSS(double sideA, double sideB, double sideC)
        {
            double S = (sideA + sideB + sideC) / 2;
            return Math.Sqrt(S * (S - sideA) * (S - sideB) * (S - sideC));
        }
        public static double AreaTriangleSAS(double sideA, double angleC, double sideB)
        {
            return 0.5f * (sideA * sideB * Math.Sin(DegToRad(angleC)));
        }
        public static double AreaTriangleSSA(double sideA, double sideB, double angleA)
        {
            double angleB = Math.Asin((sideB * Math.Sin(DegToRad(angleA))) / sideA);
            double testSum = angleB - 180 + angleA; //If (testSum < 180) {2 Triangles} If (testSum > 180) {1 Triangle}

            if(Math.Sin(angleB) > 1)
            {
                return 0;
            }
            else
            {
                return ((sideA * sideB * Math.Sin(DegToRad(180 - angleA - angleB))) / 2);
            }
        }
        public static double AreaTriangleASA(double angleA, double sideB, double angleC)
        {
            return;
        }
        public static double AreaTriangleAAS(double angleA, double angleB, double sideA)
        {
            return;
        }
    }
}
