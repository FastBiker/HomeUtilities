namespace HomeUtilities
{
    public class HomeUtilitiesRent : HomeUtilitiesBase
    {
        private const string fileName = "amounts_rent.txt";
        public HomeUtilitiesRent(string utilities)
            : base(utilities)
        {
        }

        public override event AmountAddedDelegate AmountAdded;

        public override void AddAmount(float amount)
        {
            if (amount >= 0)
            {
                using (var writer = File.AppendText(fileName))
                {
                    writer.WriteLine(amount);
                }
            }
            else
            {
                throw new Exception("Amount value outside the valid range. Entrer an amount using a number equal to or above 0");
            }

        }

        public override void AddAmount(char amount)
        {
            if (float.TryParse(amount.ToString(), out float result))
            {
                this.AddAmount(result);
            }
            else
            {
                throw new Exception("Char is not float");
            }
        }

        public override void AddAmount(string amount)
        {
            if (float.TryParse(amount, out float result))
            {
                this.AddAmount(result);
            }
            else
            {
                throw new Exception("String is not float");
            }
        }

        public override void AddAmount(int amount)
        {
            float valueInFloat = amount;
            this.AddAmount(valueInFloat);
        }

        public override void AddAmount(double amount)
        {
            float valueInFloat = (float)amount;
            this.AddAmount(valueInFloat);
        }

        public override Statistics GetStatistics()
        {
            var amountsFromFile = this.ReadAmountsFromFile();
            var result = this.CountStatistics(amountsFromFile);
            return result;
        }

        private List<float> ReadAmountsFromFile()
        {
            var amounts = new List<float>();
            if (File.Exists($"{fileName}"))
            {
                using (var reader = File.OpenText($"{fileName}"))
                {
                    var line = reader.ReadLine();
                    while (line != null)
                    {
                        var number = float.Parse(line);
                        amounts.Add(number);
                        line = reader.ReadLine();
                    }
                }
            }
            return amounts;
        }
        private Statistics CountStatistics(List<float> amounts)
        {
            var statistics = new Statistics();

            foreach (var amount in amounts)
            {
                statistics.AddAmount(amount);
            }

            return statistics;
        }
    }
}
