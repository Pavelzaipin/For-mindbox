using CalculateArea.Figures;

namespace CalculateArea
{
    public class Area
    {
        /// <summary>
        /// Получить площадь круга
        /// </summary>
        /// <param name="radius">радиус</param>
        /// <exception cref="ArgumentException"></exception>
        /// <returns>Площадь курга</returns>
        public static double Get(double radius)
        {
            return new Circle(radius).GetArea();
        }

        /// <summary>
        /// Получить площадь треугольника
        /// </summary>
        /// <param name="a">сторона А</param>
        /// <param name="b">сторона B</param>
        /// <param name="c">сторона C</param>
        /// <exception cref="ArgumentException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        /// <returns>Площадь треугольника</returns>
        public static double Get(double a, double b, double c)
        {
            return new Triangle(a, b, c).GetArea();
        }
    }
}