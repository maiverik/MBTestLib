namespace MBTestLib
{
    public class AreaCalculator
    {
        #region Формально считаем площади, требуемые в задании с помощью статики.

        public static double CalcCircleAreaByRadius(double radius)
        {
            if (radius < 0) throw new ArgumentOutOfRangeException(nameof(radius), "Circle raidus is less then 0");
            
            return Math.PI * Math.Pow(radius, 2);
        }

        public static double CalcTriangleArea(double side1, double side2, double side3)
        {
            if (side1 < 0) throw new ArgumentOutOfRangeException(nameof(side1), "Circle raidus is less then 0");
            if (side2 < 0) throw new ArgumentOutOfRangeException(nameof(side2), "Circle raidus is less then 0");
            if (side3 < 0) throw new ArgumentOutOfRangeException(nameof(side3), "Circle raidus is less then 0");
            
            var p = (side1 + side2 + side3) / 2;

            return Math.Sqrt(p*(p-side1)*(p-side2)*(p-side3));
        }

        #endregion

        #region - Легкость добавления других фигур

        // Чтобы легко добавить "другую" фигуру нужно определиться куда мы хотим ее добавить, как ее задавать и зачем нам это нужно
        // Допустим подразумевается что ее должно быть легко добавить в список фигур класса
        

        //Объявляем и инициализируем список фигур в конструкторе
        public List<IFigure> Figures { get; }
        public AreaCalculator()
        {
            Figures = new List<IFigure>();
        }

        //Легко добавляем фигуру:)
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