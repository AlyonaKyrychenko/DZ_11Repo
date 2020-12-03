namespace DZ_11
{
    /// <summary>
    ///  This class for climatic.
    /// </summary>
    internal class Climatic : Appliances
    {
        private Seasons forSeason;

        /// <summary>
        /// Initializes a new instance of the <see cref="Climatic"/> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="size">size.</param>
        /// <param name="powerConsumption">powerConsumption.</param>
        /// <param name="manufacturer">manufacturer.</param>
        /// <param name="forSeason">forSeason.</param>
        public Climatic(string name, Size size, int powerConsumption, string manufacturer, decimal price, Seasons forSeason)
        {
            this.Name = name;
            this.Size = size;
            this.PowerConsumption = powerConsumption;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.ForSeason = forSeason;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Climatic"/> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="size">size.</param>
        /// <param name="powerConsumption">powerConsumption.</param>
        /// <param name="manufacturer">manufacturer.</param>
        /// <param name="forSeason">forSeason.</param>
        /// <param name="plugged">plugged.</param>
        public Climatic(string name, Size size, int powerConsumption, string manufacturer, decimal price, Seasons forSeason, bool plugged)
        {
            this.Name = name;
            this.Size = size;
            this.PowerConsumption = powerConsumption;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.ForSeason = forSeason;
            this.Plugged = plugged;
        }

        /// <summary>
        ///  Gets or sets a value indicating whether gets or sets .
        /// </summary>
        public Seasons ForSeason { get => this.forSeason; set => this.forSeason = value; }
    }
}
