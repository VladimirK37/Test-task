using ShapeUtilLibrary;
using System;
using Xunit;

namespace ShapeUtilLibraryTests
{
    public class TriangleTest
    {
        [Fact]
        public void TestGetArea()
        {
            //Arrange
            Triangle triangle = new Triangle(2, 4, 5);
            double halfPerimeterTest = (double)(2 + 4 + 5) / 2;
            double expected = Math.Sqrt(halfPerimeterTest * (halfPerimeterTest - 2) * (halfPerimeterTest - 4) * (halfPerimeterTest - 5));

            //Act
            double actual = triangle.GetArea();

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestGetAreaException()
        {
            //Arrange
            Triangle triangle = new Triangle(0, 0, 0);

            //Act

            //Assert
            Assert.Throws<ArgumentException>(() => triangle.GetArea());
        }

        [Fact]
        public void TestIsValidNegativeNumber()
        {
            //Arrange
            Triangle triangle = new Triangle(-1, -5, -7);

            //Act
            bool actual = triangle.IsValid();

            //Assert
            Assert.False(actual);
        }

        [Fact]
        public void TestIsValidNaN()
        {
            //Arrange
            Triangle triangle = new Triangle(double.NaN, -5, double.NaN);

            //Act
            bool actual = triangle.IsValid();

            //Assert
            Assert.False(actual);
        }

        [Fact]
        public void TestIsValidTrue()
        {
            //Arrange
            Triangle triangle = new Triangle(3, 4, 6);

            //Act
            bool actual = triangle.IsValid();

            //Assert
            Assert.True(actual);
        }

        [Fact]
        public void TestIsRightTriangle()
        {
            //Arrange
            Triangle triangle = new Triangle(3, 4, 5);

            //Act
            bool actual = triangle.IsRightTriangle();

            //Assert
            Assert.True(actual);
        }

        [Fact]
        public void TestIsRightTriangleFalse()
        {
            //Arrange
            Triangle triangle = new Triangle(2, 2, 3);

            //Act
            bool actual = triangle.IsRightTriangle();

            //Assert
            Assert.False(actual);
        }
    }
}
