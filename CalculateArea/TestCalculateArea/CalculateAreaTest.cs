using NUnit.Framework.Internal;
using CalculateArea.Figures;

namespace TestCalculateArea
{
    [TestClass]
    public class CalculateAreaTest
    {
        /// <summary>
        /// Проверка отрицательных значений для радиуса круга
        /// </summary>
        [TestMethod]
        public void CircleNegativeRadius()
        {
            Assert.ThrowsException<ArgumentException>(() => new Circle(-5));
        }

        /// <summary>
        /// Проверка положительных значений для радиуса круга
        /// </summary>
        [TestMethod]
        public void CirclePositiveRadius()
        {
            new Circle(5);
        }

        /// <summary>
        /// Проверка правильности вычисления радиуса 
        /// </summary>
        [TestMethod]
        public void CircleRightRadius()
        {
            double rightRadius = 78.53981633974483;

            double circleRadius = new Circle(5).GetArea();

            Assert.AreEqual(rightRadius, circleRadius);
        }

        /// <summary>
        /// Проверка может ли существовать такой треугольник
        /// </summary>
        [TestMethod]
        public void TriangleWrongSideValues()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Triangle(5, 0, 0));
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Triangle(0, 5, 0));
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Triangle(0, 0, 5));
        }

        /// <summary>
        /// Проврка отрицательных значений 
        /// </summary>
        [TestMethod]
        public void TriangleNegativeSideValues()
        {
            Assert.ThrowsException<ArgumentException>(() => new Triangle(-1, 1, 1));
            Assert.ThrowsException<ArgumentException>(() => new Triangle(1, -1, 1));
            Assert.ThrowsException<ArgumentException>(() => new Triangle(1, 1, -1));
        }

        /// <summary>
        /// Проверка правильности вычесления площади треугольника
        /// </summary>
        [TestMethod]
        public void TriangleRightAreaValue() 
        {
            double rightValue = 4.14578098794425;

            double triangle = new Triangle(5, 3, 3).GetArea();

            Assert.AreEqual(rightValue, triangle);
        }

        /// <summary>
        /// Проверка правильности вычисления является ли теругольник прямоугольным  
        /// </summary>
        [TestMethod]
        public void TriangleIsRightTriangle()
        {
            Assert.IsTrue(new Triangle(5, 3, 4).IsRightTriangle);
            Assert.IsTrue(new Triangle(3, 5, 4).IsRightTriangle);
            Assert.IsTrue(new Triangle(3, 4, 5).IsRightTriangle);
        }
    }
}