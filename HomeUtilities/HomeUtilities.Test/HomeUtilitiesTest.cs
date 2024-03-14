namespace HomeUtilities.Test
{
    public class HomeUtilitiesTest
    {
        [Test]
        public void WhenEnterAmountsUtilities_ShouldCorrectStatistics()
        {
            //arrange
            var cash = new HomeUtilitiesGas("Wybuch");
            cash.AddAmount(120);
            cash.AddAmount(80);
            cash.AddAmount(100);

            //act
            var statistic = cash.GetStatistics();

            //assert
            Assert.AreEqual(120, statistic.Max);
            Assert.AreEqual(80, statistic.Min);
            Assert.AreEqual(Math.Round(100.00,2), Math.Round(statistic.Average, 2));
        }
    }
}