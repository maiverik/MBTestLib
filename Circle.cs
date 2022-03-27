using static MBTestLib.GeometrySolver;
namespace MBTestLib
{
    /// <summary>
    /// Представляет фигуру "Круг" и методы работы с ней.
    /// </summary>
    public class Circle : IFigure
    {
        /// <summary>
        /// Возвращает радиус круга
        /// </summary>
        public double Radius { get; }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Circle"/> по радиусу круга
        /// </summary>
        /// <param name="radius"></param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public Circle(double radius)
        {
            if (radius < 0) throw new ArgumentOutOfRangeException(nameof(radius), "Circle raidus is less then 0");
            this.Radius = radius;
        }

        /// <summary>
        /// Возвращает площадь круга
        /// </summary>
        /// <returns></returns>
        public double CalcArea()
        {
            return CalcCircleAreaByRadius(Radius);
        }


    }
}
