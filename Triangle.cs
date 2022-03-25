

namespace MBTestLib
{
    /// <summary>
    /// Класс для задания треугольника. Ограничимся тем что наш треугольник можно задать только по 3м сторонам.
    /// </summary>
    public class Triangle : IFigure
    {
        
        public double side1 { get; }
        public double side2 { get; }
        public double side3 { get; }

        /// <summary>
        /// Задать треугольник по 3м сторонам
        /// </summary>
        /// <param name="side1"></param>
        /// <param name="side2"></param>
        /// <param name="side3"></param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        /// <exception cref="ArgumentException"></exception>
        public Triangle(double side1, double side2, double side3)
        {
            if (side1 <= 0) throw new ArgumentOutOfRangeException(nameof(side1), "Side 1 can't be equal or less then 0");
            if (side2 <= 0) throw new ArgumentOutOfRangeException(nameof(side2), "Side 2 can't be equal or less then 0");
            if (side3 <= 0) throw new ArgumentOutOfRangeException(nameof(side3), "Side 3 can't be equal or less then 0");

            if (!IsTriangleWithSidesPossible(side1, side2, side3)) throw new ArgumentException("Triangle is not possible with these sides");
            
            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;
            
        }

        /// <summary>
        /// Возможен ли треугольник с заданными сторонами
        /// </summary>
        /// <param name="side1"></param>
        /// <param name="side2"></param>
        /// <param name="side3"></param>
        /// <returns></returns>
        public static bool IsTriangleWithSidesPossible(double side1, double side2, double side3)
        {
            var s1s2 = side1 + side2;
            var s1s3 = side1 + side3;
            var s2s3 = side2 + side3;

            return !(s1s2 <= side3 || s1s3 <= side2 || s2s3 <= side1);
        }

        public static bool IsTriangleRight(double side1, double side2, double side3)
        {
            double[] sides = { side1, side2, side3 };
            var oSides = from side in sides
                         orderby side descending
                         select side;
            var a = oSides.ElementAt(0);
            var b = oSides.ElementAt(1);
            var c = oSides.ElementAt(2);
            return a * a - b * b - c * c <= double.Epsilon;
        }

        /// <summary>
        /// Вычислить площадь треугольника по 3м сторонам
        /// </summary>
        /// <returns></returns>
        public double CalcArea()
        {
            return AreaCalculator.CalcTriangleArea(side1, side2, side3);
        }

        /// <summary>
        /// Определить прямоугольность треугольника по теореме Пифагора
        /// </summary>
        /// <returns></returns>
        public bool IsThisTriangleRight()
        {
            return IsTriangleRight(this.side1, this.side2, this.side3);
        }
    }
}
