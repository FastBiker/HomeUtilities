using static HomeUtilities.HomeUtilitiesBase;

namespace HomeUtilities
{
    public interface IHomeUtilities
    {
        string Utilities { get; }
        void AddAmount(float amount);
        void AddAmount(char amount);
        void AddAmount(string amount);
        void AddAmount(int amount);
        void AddAmount(double amount);

        event AmountAddedDelegate AmountAdded;

        Statistics GetStatistics();
    }
}
