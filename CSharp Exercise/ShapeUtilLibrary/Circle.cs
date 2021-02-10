using System;

namespace ShapeUtilLibrary
{
    /// <summary>
    /// Class defines circle shape
    /// </summary>
    public class Circle : Shape
    {
        private double Radius { get; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        ///<inheritdoc/>
        public override double GetArea()
        {
            if (!IsValid())
                throw new ArgumentException("The circle does not exist");

            return Math.PI * Math.Pow(Radius, 2);
        }

        ///<inheritdoc/>
        public override bool IsValid()
        {
            return Radius > 0;
        }
    }
}
