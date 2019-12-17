using AreaCalculationFigures;
using AreaCalculationFigures.Figures;
using NUnit.Framework;

namespace TestAreaCalculation
{
  
    public class TestResult
    {
        private AreaCalculation _calculation;

        [Test]
        public void AreaCircle()
        {
            var radius = 10;
            var area = 314.16;
            _calculation = new AreaCalculation(new Circle(radius));
            Assert.AreEqual(area, _calculation.Result());
        }

        [Test]
        public void AreaTriange()
        {
            var a = 10;
            var b = 10;
            var c = 10;
            var result = 43.30;
            _calculation = new AreaCalculation(new Triangle(a, b, c));
            Assert.AreEqual(_calculation.Result(), result);
        }



    }
}