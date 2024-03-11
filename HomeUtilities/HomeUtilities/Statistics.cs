namespace HomeUtilities
{
    public class Statistics
    {
        public float Max { get; set; }

        public float Min { get; set; }

        public float Sum { get; set; }

        public int Count { get; set; }

        public float Average
        {
            get
            {
                return this.Sum / this.Count;
            }
        }

        public Statistics()
        {
            this.Sum = 0;
            this.Count = 0;
            this.Max = float.MinValue;
            this.Min = float.MaxValue;
        }

        public void AddAmount(float amount)
        { 
            this.Sum += amount;
            this.Count++;
            this.Max = Math.Max(this.Max, amount);
            this.Min = Math.Min(this.Min, amount);
        }
    }
}
