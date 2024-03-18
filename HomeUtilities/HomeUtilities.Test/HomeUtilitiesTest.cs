namespace HomeUtilities.Test
{
    public class HomeUtilitiesTest
    {
        [Test]
        public void WhenEnterAmountsGas_ShouldCorrectStatistics()
        {
            //arrange
            var cash = new HomeUtilitiesGas("Wybuch");
            cash.AddAmount(120);
            cash.AddAmount(1);
            cash.AddAmount(160);

            //act
            var statistic = cash.GetStatistics();

            //assert
            Assert.AreEqual(160, statistic.Max);
            Assert.AreEqual(1, statistic.Min);
            Assert.AreEqual(Math.Round(93.67,2), Math.Round(statistic.Average, 2));
        }
        [Test]
        public void WhenEnterAmountsWater_ShouldCorrectStatistics()
        {
            //arrange
            var money = new HomeUtilitiesWater("PowódŸ");
            money.AddAmount(45f);
            money.AddAmount("57");
            money.AddAmount('7');
            money.AddAmount(790L);


            //act
            var statistic = money.GetStatistics();

            //assert
            Assert.AreEqual(790, statistic.Max);
            Assert.AreEqual(7, statistic.Min);
            Assert.AreEqual(Math.Round(224.75, 2), Math.Round(statistic.Average, 2));
        }
        [Test]
        public void WhenEnterAmountsGarbage_ShouldCorrectStatistics()
        {
            //arrange
            var garbage = new HomeUtilitiesGarbage("PSZOK");
            garbage.AddAmount(11);
            garbage.AddAmount(12);
            garbage.AddAmount(25);

            //act
            var statistic = garbage.GetStatistics();

            //assert
            Assert.AreEqual(25, statistic.Max);
            Assert.AreEqual(11, statistic.Min);
            Assert.AreEqual(Math.Round(16.00, 2), Math.Round(statistic.Average, 2));
        }
        [Test]
        public void WhenEnterAmountsSewage_ShouldCorrectStatistics()
        {
            //arrange
            var sewage = new HomeUtilitiesSewage("Oczyszczalnia");
            sewage.AddAmount(54);
            sewage.AddAmount(96);
            sewage.AddAmount(107);

            //act
            var statistic = sewage.GetStatistics();

            //assert
            Assert.AreEqual(107, statistic.Max);
            Assert.AreEqual(54, statistic.Min);
            Assert.AreEqual(Math.Round(85.67, 2), Math.Round(statistic.Average, 2));
        }
        [Test]
        public void WhenEnterAmountsElectricty_ShouldCorrectStatistics()
        {
            //arrange
            var electricity = new HomeUtilitiesElectricity("Ciemnoœæ");
            electricity.AddAmount(330);
            electricity.AddAmount(160);
            electricity.AddAmount(133);

            //act
            var statistic = electricity.GetStatistics();

            //assert
            Assert.AreEqual(330, statistic.Max);
            Assert.AreEqual(133, statistic.Min);
            Assert.AreEqual(Math.Round(207.67, 2), Math.Round(statistic.Average, 2));
        }
        [Test]
        public void WhenEnterAmountsRent_ShouldCorrectStatistics()
        {
            //arrange
            var rent = new HomeUtilitiesRent("¯o³d");
            rent.AddAmount(2700L);
            rent.AddAmount(2800d);
            rent.AddAmount("3000");

            //act
            var statistic = rent.GetStatistics();

            //assert
            Assert.AreEqual(3000, statistic.Max);
            Assert.AreEqual(2700, statistic.Min);
            Assert.AreEqual(Math.Round(2833.33, 2), Math.Round(statistic.Average, 2));
        }
        [Test]
        public void WhenEnterAmountsInternet_ShouldCorrectStatistics()
        {
            //arrange
            var internet = new HomeUtilitiesInternet("Ciemnoœæ");
            internet.AddAmount(56);
            internet.AddAmount(79);
            internet.AddAmount(109);

            //act
            var statistic = internet.GetStatistics();

            //assert
            Assert.AreEqual(109, statistic.Max);
            Assert.AreEqual(56, statistic.Min);
            Assert.AreEqual(Math.Round(81.33, 2), Math.Round(statistic.Average, 2));
        }
    }
}
