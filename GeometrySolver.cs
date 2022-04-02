namespace MBTestLib
{
    public static class GeometrySolver
    {
        /// <summary>
        /// Вычисляет площадь круга по радиусу
        /// </summary>
        /// <param name="radius"></param>
        /// <returns></returns>
        public static double CalculateCircleArea(double radius)
        {
            return new Circle(radius).Area;
        }

        /// <summary>
        /// Вычисляет площадь треугольника по трем сторонам
        /// </summary>
        /// <param name="side1"></param>
        /// <param name="side2"></param>
        /// <param name="side3"></param>
        /// <returns></returns>
        public static double CalculateTriangleArea(double side1, double side2, double side3)
        {
            return new Triangle(side1, side2, side3).Area;
        }

        /// <summary>
        /// Определяет является ли треугольник, заданный тремя сторонами, прямоугольным
        /// </summary>
        /// <param name="side1"></param>
        /// <param name="side2"></param>
        /// <param name="side3"></param>
        /// <returns></returns>
        public static bool IsTriangleRight(double side1, double side2, double side3)
        {
            return new Triangle(side1, side2, side3).IsRight;
        }

        /// <summary>
        /// Возвращает площадь произвольной фигуры
        /// </summary>
        /// <param name="fig"></param>
        /// <returns></returns>
        public static double GetFigureArea(Figure fig)
        {
            return fig.Area;
        }
    }
}
