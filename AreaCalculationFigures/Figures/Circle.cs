using AreaCalculationFigures.AreaStrategyInterface;
using  static  System.Math;

namespace AreaCalculationFigures.Figures
{
    public class Circle : IAreaCalculationStrategy
    {
        private double _radius;

        public Circle(double radius) => _radius = radius;

        public double Result ()=> PI * Pow(_radius, 2);
    }
}
