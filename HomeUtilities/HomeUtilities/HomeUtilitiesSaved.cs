namespace HomeUtilities
{
    public class HomeUtilitiesSaved : HomeUtilitiesBase
    {
        private const string fileName = "_amounts.txt";
        private string fullFileName;
        public HomeUtilitiesSaved(string name)
            : base(name)
        {
            fullFileName = $"{name}_{fileName}";
        }

        public override event AmountAddedDelegate AmountAdded;

        public override void AddAmount(float amount)
        {
            if (amount >= 0)
            {
                using (var writer = File.AppendText(fullFileName))
                {
                    writer.WriteLine(amount);
                }
                if (AmountAdded != null)
                {
                    AmountAdded(this, new EventArgs());
                }
            }
            else
            {
                throw new Exception("Amount value outside the valid range. Enter an amount using a number equal to or above 0");
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
            if (File.Exists($"{fullFileName}"))
            {
                using (var reader = File.OpenText($"{fullFileName}"))
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
