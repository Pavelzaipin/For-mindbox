using CalculateArea.Interfaces;
using static System.Math;

namespace CalculateArea.Figures
{
    public class Triangle : IFigure
    {
        #region Fields
        /// <summary>
        /// Название 
        /// </summary>
        public string Name
        {
            get
            {
                return "Треугольник";
            }
        }

        /// <summary>
        /// Является ли треугольник прямоугольным
        /// </summary>
        public bool IsRightTriangle 
        { 
            get 
            { 
                return _isRightTriangle;
            } 
        }

        private double _a;
        private double _b;
        private double _c;
        private bool _isRightTriangle;
        #endregion

        /// <summary>
        /// Установливает значения сторон треугольника и проверяет на правильность
        /// </summary>
        /// <param name="a">сторона А</param>
        /// <param name="b">сторона B</param>
        /// <param name="c">сторона C</param>
        /// <exception cref="ArgumentException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public Triangle(double a, double b, double c)
        {
            if (a < 0 || b < 0 || c < 0)
            {
                throw new ArgumentException($"Одно из зачений меньше нуля  a: {a}, b: {b}, c: {c}");
            }
            if ( a > b + c || b > a + c || c > a + b)
            {
                throw new ArgumentOutOfRangeException(
                    $"Не может быть треугольником, как как одна из сторон больше суммы двух других a: {a}, b: {b}, c: {c}");
            }
            
            _a = a;
            _b = b;
            _c = c;

            SetIsRightTriangle();
        }

        /// <summary>
        /// Проверка является ли треугольник прямоугольным
        /// </summary>
        private void SetIsRightTriangle()
        {
            if (Pow(_a, 2) + Pow(_b, 2) == Pow(_c, 2)) 
            {
                _isRightTriangle = true;
            }
            else if (Pow(_a, 2) + Pow(_c, 2) == Pow(_b, 2))
            {
                _isRightTriangle = true;
            }
            else if (Pow(_b, 2) + Pow(_c, 2) == Pow(_a, 2))
            {
                _isRightTriangle = true;
            }
            else
            {
                _isRightTriangle= false;
            }
        }

        /// <summary>
        /// Получить площадь треугольника
        /// </summary>
        /// <returns>Площадь треугольника</returns>
        public double GetArea()
        {
            double s = (_a + _b + _c) / 2.0;
            return Sqrt(s * (s - _a) * (s - _b) * (s - _c));
        }
    }
}
