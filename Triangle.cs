
namespace MBTestLib
{
    /// <summary>
    /// Представляет фигуру "Треугольник" и методы работы с ней.
    /// </summary>
    /// <remarks>
    /// Ограничимся тем, что наш треугольник можно задать только по 3м сторонам.
    /// </remarks>
    public class Triangle : Figure
    {
        public double Side1 { get; }
        public double Side2 { get; }
        public double Side3 { get; }

        /// <summary>
        /// Возвращает является ли треугольник прямоугольным
        /// </summary>
        public bool IsRight { get; }

        /// <summary>
        /// Возвращает площадь треугольника
        /// </summary>
        public override double Area { get; }

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
            this.Side1 = side1;
            this.Side2 = side2;
            this.Side3 = side3;

            CheckTriangleWithSidesIsPossible();

            this.Area = CalcTriangleArea();
            this.IsRight = IsTriangleRight();
        }

        /// <summary>
        /// Проверяет стороны треугольника на >=0
        /// </summary>
        /// <param name="side1"></param>
        /// <param name="side2"></param>
        /// <param name="side3"></param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        private void CheckTriangleSidesZeroOrLess()
        {
            if (Side1 <= 0) throw new ArgumentOutOfRangeException("Side 1 can't be equal or less then 0");
            if (Side2 <= 0) throw new ArgumentOutOfRangeException("Side 2 can't be equal or less then 0");
            if (Side3 <= 0) throw new ArgumentOutOfRangeException("Side 3 can't be equal or less then 0");
        }

        /// <summary>
        /// Определяет возможен ли треугольник с указанными сторонами
        /// </summary>
        /// <param name="side1"></param>
        /// <param name="side2"></param>
        /// <param name="side3"></param>
        /// <returns></returns>
        private void CheckTriangleWithSidesIsPossible()
        {
            CheckTriangleSidesZeroOrLess();

            var s1s2 = Side1 + Side2;
            var s1s3 = Side1 + Side3;
            var s2s3 = Side2 + Side3;

            if (s1s2 <= Side3 || s1s3 <= Side2 || s2s3 <= Side1) throw new ArgumentException("Triangle is not possible with these Sides");
        }

        /// <summary>
        /// Вычисляет площадь треугольника
        /// </summary>
        /// <returns></returns>
        private double CalcTriangleArea()
        {
            var p = (Side1 + Side2 + Side3) / 2;

            return Math.Round(Math.Sqrt(p * (p - Side1) * (p - Side2) * (p - Side3)), 4);
        }

        /// <summary>
        /// Определяет является ли треугольник с указанными сторонами прямоугольным
        /// </summary>
        /// <returns></returns>
        private bool IsTriangleRight()
        {
            double[] Sides = { Side1, Side2, Side3 };
            var oSides = from Side in Sides
                         orderby Side descending
                         select Side;
            var a = oSides.ElementAt(0);
            var b = oSides.ElementAt(1);
            var c = oSides.ElementAt(2);

            return a * a - b * b - c * c <= double.Epsilon;
        }
    }
}
