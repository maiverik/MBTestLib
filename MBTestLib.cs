namespace MBTestLib
{
    /// <summary>
    /// Представляет методы геометрических вычислений над фигурами. 
    /// Также представлет метод <see cref="CreateFiguresList"/>, реализующий требования задания
    /// </summary>
    public static class GeometrySolver
    {

        /// <summary>
        /// Вычисляет площадь круга по его радиусу
        /// </summary>
        /// <param name="radius">Радиус круга</param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static double CalcCircleAreaByRadius(double radius)
        {
            if (radius < 0) throw new ArgumentOutOfRangeException(nameof(radius), "Circle radius is less then 0");

            return Math.PI * Math.Pow(radius, 2);
        }

        /// <summary>
        /// Вычисляет площадь треугольника по 3м сторонам
        /// </summary>
        /// <param name="side1"></param>
        /// <param name="side2"></param>
        /// <param name="side3"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static double CalcTriangleArea(double side1, double side2, double side3)
        {
            if (side1 < 0) throw new ArgumentOutOfRangeException(nameof(side1), "Circle radius is less then 0");
            if (side2 < 0) throw new ArgumentOutOfRangeException(nameof(side2), "Circle radius is less then 0");
            if (side3 < 0) throw new ArgumentOutOfRangeException(nameof(side3), "Circle radius is less then 0");

            var p = (side1 + side2 + side3) / 2;

            return Math.Sqrt(p * (p - side1) * (p - side2) * (p - side3));
        }

        /// <summary>
        /// Определяет возможен ли треугольник с указанными сторонами
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

        /// <summary>
        /// Определяет является ли треугольник с указанными сторонами прямоугольным
        /// </summary>
        /// <returns></returns>
        public static bool IsTriangleRight(double side1, double side2, double side3)
        {
            if (!IsTriangleWithSidesPossible(side1, side2, side3)) throw new ArgumentException("Triangle is not possible with these sides");
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
        /// Создает список произвольных фигур и вычисляет сумму их площадей
        /// </summary>
        public static double CreateFiguresList()
        {
            //создаем список произвольных фигур, в который, при наличии реализации, можно будет легко добавить новую фигуру 
            var l = new List<IFigure>();
            l.AddRange(new IFigure[] { new Circle(1), new Triangle(3, 4, 5) });

            //считаем сумму площадей всех фигур в списке
            double areaSum = 0;
            l.ForEach(f => areaSum+=f.CalcArea());
            return areaSum;
        }
       
    }
}