namespace CompTest
{
    public class Tests
    {
        [Test]
        public void CalculateSumIteratively_Test()
        {
            var result = SeriesSumComponent.SeriesSumCalculator.CalculateSumIteratively(1);
            Assert.That(Math.Round(result, 3), Is.EqualTo(0.572));
        }

        [Test]
        public void RecursiveSeriesSum_Test()
        {
            var result = SeriesSumComponent.SeriesSumCalculator.RecursiveSeriesSum(1, 1, 0.0000001);
            Assert.That(Math.Round(result, 3), Is.EqualTo(0.572));
        }
    }
}