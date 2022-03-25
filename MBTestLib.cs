namespace MBTestLib
{
    public class AreaCalculator
    {
        #region Формально считаем площади, требуемые в задании с помощью статики.
        /// <summary>
        /// Вычисоление площади круга по его радиусу
        /// </summary>
        /// <param name="radius">радиус круга</param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static double CalcCircleAreaByRadius(double radius)
        {
            if (radius < 0) throw new ArgumentOutOfRangeException(nameof(radius), "Circle radius is less then 0");
            
            return Math.PI * Math.Pow(radius, 2);
        }

        /// <summary>
        /// Вычисление площади треугольника по 3м сторонам
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

            return Math.Sqrt(p*(p-side1)*(p-side2)*(p-side3));
        }

        #endregion

        #region - Легкость добавления других фигур

        // Чтобы легко добавить "другую" фигуру нужно определиться куда мы хотим ее добавить, как ее задавать и зачем нам это нужно
        // Допустим подразумевается что ее должно быть легко добавить в список фигур класса
        

        //Объявляем и инициализируем список фигур в конструкторе

        /// <summary>
        /// Список созданных фигур
        /// </summary>
        public List<IFigure> Figures { get; }
        
        public AreaCalculator()
        {
            Figures = new List<IFigure>();
        }

        //Легко добавляем фигуру :)

        /// <summary>
        /// Добавляет фигуру в список
        /// </summary>
        /// <param name="figure"></param>
        public void AddFigure(IFigure figure)
        {
            this.Figures.Add(figure);
        }

        #endregion region

        #region - Вычисление площади фигуры без знания типа фигуры в compile-time
        //Будем считать что под этим имелся ввиду метод CalcArea из интерфейса IFigure 
        #endregion
    }
}