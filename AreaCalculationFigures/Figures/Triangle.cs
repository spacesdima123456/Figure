using AreaCalculationFigures.AreaStrategyInterface;
using static System.Math;

namespace AreaCalculationFigures.Figures
{
    public class Triangle: IAreaCalculationStrategy
    {
        private double _a;
        private double _b;
        private double _c;


        public Triangle(double a, double b, double c)
        {
            this._a = a;
            this._b = b;
            this._c = c;
        }

        private double Perimeter() => (_a + _b + _c) * 0.5;

        public double Result()
        {
            var perimeter = Perimeter();
            var area = perimeter * (perimeter - _a) * (perimeter - _b) * (perimeter - _c);
            area = Sqrt(area);
            return area;
        }
    }
}
