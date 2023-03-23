using CalculateArea.Interfaces;

namespace CalculateArea.Figures
{
    public class Circle : IFigure
    {
        #region
        /// <summary>
        /// Имя фигуры
        /// </summary>
        public string Name
        {
            get
            {
                return "Круг";
            }
        }
        
        /// <summary>
        /// Радиус
        /// </summary>
        private double _radius;
        #endregion Fields

        /// <param name="radius">вапвап</param>
        /// <exception cref="ArgumentException"></exception>
        public Circle(double radius)
        {
            if(radius < 0)
            {
                throw new ArgumentException("Радиус не может быть меньше нуля");
            }
           _radius = radius;
        }

        /// <summary>
        /// Получить радиус круга
        /// </summary>
        /// <returns>Радиус круга</returns>
        public double GetArea()
        {
            return Math.PI * _radius * _radius;
        }
    }
}
