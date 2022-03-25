
namespace MBTestLib
{
    /// <summary>
    /// Класс для задания круга.
    /// </summary>
    public class Circle : IFigure
    {
        /// <summary>
        /// Радиус круга
        /// </summary>
        public double radius { get; set; }

        /// <summary>
        /// Задать круг через его радиус
        /// </summary>
        /// <param name="radius"></param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public Circle(double radius)
        {
            if (radius < 0) throw new ArgumentOutOfRangeException(nameof(radius), "Circle raidus is less then 0");
            this.radius = radius;
        }

        /// <summary>
        /// Вычислить площадь круга
        /// </summary>
        /// <returns></returns>
        public double CalcArea()
        {
            return AreaCalculator.CalcCircleAreaByRadius(radius);
        }


    }
}
