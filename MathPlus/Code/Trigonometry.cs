using System;

namespace MathPlus.Code
{
    class Trigonometry
    {
        public static double AreaTriangleSSS(double sideA, double sideB, double sideC)
        {
            double S = (sideA + sideB + sideC) / 2;
            return Math.Sqrt(S * (S - sideA) * (S - sideB) * (S - sideC));
        }
        public static double AreaTriangleSAS(double sideA, double angleC, double sideB)
        {
            return 0.5f * (sideA * sideB * Math.Sin(angleC));
        }
        public static double AreaTriangleSSA(double sideA, double sideB, double angleA)
        {
            double angleB = angleA * sideB / sideA;
            double testSum = angleB - 180 + angleA;
            if(testSum < 180)
            {
                //dothetwotrianglething
                return;
            }
            else if(testSum > 180)
            {
                //ContinueCalculations?
                return;
            }
            else if(Math.Sin(angleB) > 1)
            {
                return 0;
            }
            else
            {
                return 0;
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
