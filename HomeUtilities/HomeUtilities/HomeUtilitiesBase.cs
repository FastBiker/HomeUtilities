namespace HomeUtilities
{
    public abstract class HomeUtilitiesBase : IHomeUtilities
    {
        public delegate void AmountAddedDelegate(object sender, EventArgs args);
        
        public abstract event AmountAddedDelegate AmountAdded;

        public HomeUtilitiesBase(string name)
        {
            this.Name = name;
        }

        public string Name { get; private set; }

        public abstract void AddAmount(float amount);

        public abstract void AddAmount(char amount);

        public abstract void AddAmount(string amount);

        public abstract void AddAmount(int amount);

        public abstract void AddAmount(double amount);

        public abstract Statistics GetStatistics();
    }
}
