namespace MBTestLib
{
    /// <summary>
    /// Представляет фигуру "Круг" и методы работы с ней.
    /// </summary>
    public class Circle : Figure
    {
        /// <summary>
        /// Возвращает радиус круга
        /// </summary>
        public double Radius { get; }

        /// <summary>
        /// Возвращает площадь круга
        /// </summary>
        public override double Area { get; }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Circle"/> по радиусу круга
        /// </summary>
        /// <param name="radius"></param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public Circle(double radius)
        {
            this.Radius = radius;
            CheckRadius();
            this.Area = CalcCircleArea();
        }

        /// <summary>
        /// Вычисляет площадь круга по его радиусу
        /// </summary>
        /// <returns></returns>
        private double CalcCircleArea()
        {
            return Math.Round(Math.PI * Math.Pow(Radius, 2), 4);
        }

        /// <summary>
        /// Проверяет радиус на >=0
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        private void CheckRadius()
        {
            if (Radius <= 0) throw new ArgumentOutOfRangeException("Circle raidus can't be equal or less then 0");
        }
    }
}
