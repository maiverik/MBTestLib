
namespace MBTestLib
{
    /// <summary>
    /// Класс для задания круга.
    /// </summary>
    public class Circle : IFigure
    {
        public double radius { get; set; }

        public Circle(double radius)
        {
            if (radius < 0) throw new ArgumentOutOfRangeException(nameof(radius), "Circle raidus is less then 0");
            this.radius = radius;
        }


        public double CalcArea()
        {
            return AreaCalculator.CalcCircleAreaByRadius(radius);
        }


    }
}
