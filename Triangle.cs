using static MBTestLib.GeometrySolver;

namespace MBTestLib
{
    /// <summary>
    /// Представляет фигуру "Треугольник" и методы работы с ней.
    /// </summary>
    /// <remarks>
    /// Ограничимся тем, что наш треугольник можно задать только по 3м сторонам.
    /// </remarks>
    public class Triangle : IFigure
    {
       

        public double Side1 { get; }
        public double Side2 { get; }
        public double Side3 { get; }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Triangle"/> по 3м сторонам
        /// </summary>
        /// <param name="side1"></param>
        /// <param name="side2"></param>
        /// <param name="side3"></param>
        /// <exception cref="ArgumentOutOfRangeException">Размер стороны меньше или равен 0</exception>
        /// <exception cref="ArgumentException">Если треугольник с указанными сторонами невозможен</exception>
        public Triangle(double side1, double side2, double side3)
        {
            if (side1 <= 0) throw new ArgumentOutOfRangeException(nameof(side1), "Side 1 can't be equal or less then 0");
            if (side2 <= 0) throw new ArgumentOutOfRangeException(nameof(side2), "Side 2 can't be equal or less then 0");
            if (side3 <= 0) throw new ArgumentOutOfRangeException(nameof(side3), "Side 3 can't be equal or less then 0");

            if (!IsTriangleWithSidesPossible(side1, side2, side3)) throw new ArgumentException("Triangle is not possible with these sides");
            
            this.Side1 = side1;
            this.Side2 = side2;
            this.Side3 = side3;
            
        }

        /// <summary>
        /// Вычисляет площадь треугольника
        /// </summary>
        /// <returns></returns>
        public double CalcArea()
        {
            return CalcTriangleArea(Side1, Side2, Side3);
        }

        /// <summary>
        /// Определяет является ли треугольник прямоугольным
        /// </summary>
        /// <returns></returns>
        public bool IsThisTriangleRight()
        {
            return IsTriangleRight(this.Side1, this.Side2, this.Side3);
        }
    }
}
