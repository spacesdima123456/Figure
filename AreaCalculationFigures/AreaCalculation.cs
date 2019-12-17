using AreaCalculationFigures.AreaStrategyInterface;
using static  System.Math;

namespace AreaCalculationFigures
{
    public class AreaCalculation
    {
        private readonly IAreaCalculationStrategy _calculationStrategy;

        public AreaCalculation(IAreaCalculationStrategy calculationStrategy)
        {
            _calculationStrategy = calculationStrategy;
        }

        public double Result() =>  Round(_calculationStrategy.Result(),2);

    }
}
