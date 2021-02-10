using System;

namespace ShapeUtilLibrary
{
    public class Triangle : Shape
    {
        public double Side1 { get; }

        public double Side2 { get; }

        public double Side3 { get; }

        public Triangle(double side1, double side2, double side3)
        {
            if (side1 > side2)
                HelpUtil.SwapVariables(ref side1, ref side2);

            if (side1 > side3)
                HelpUtil.SwapVariables(ref side1, ref side3);

            if (side2 > side3)
                HelpUtil.SwapVariables(ref side2, ref side3);

            Side1 = side1;
            Side2 = side2;
            Side3 = side3;
        }

        public override double GetArea()
        {
            if (!IsValid())
                throw new ArgumentException("The triangle does not exist.");

            double halfPerimeter = (Side1 + Side2 + Side3) / 2;
            return Math.Sqrt(halfPerimeter * (halfPerimeter - Side1) * (halfPerimeter - Side2) * (halfPerimeter - Side3));
        }

        public override bool IsValid()
        {
            return Side1 > 0 && Side2 > 0 && Side3 > 0 && Side1 + Side2 > Side3;
        }

        public bool IsRightTriangle()
        {
            if (IsValid())
            {
                return Math.Pow(Side3, 2) == Math.Pow(Side2, 2) + Math.Pow(Side1, 2);
            }

            return false;
        }
    }
}
