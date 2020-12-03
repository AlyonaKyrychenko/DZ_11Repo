namespace DZ_11
{
    /// <summary>
    ///  This class for clothing care.
    /// </summary>
    public class ForClothingCare : Appliances
    {
        private Modes mode;

        /// <summary>
        /// Initializes a new instance of the <see cref="ForClothingCare"/> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="size">size.</param>
        /// <param name="powerConsumption">powerConsumption.</param>
        /// <param name="manufacturer">manufacturer.</param>
        /// <param name="mode">mode.</param>
        public ForClothingCare(Name name, Size size, int powerConsumption, string manufacturer, decimal price, Modes mode)
        {
            this.Name = name;
            this.Size = size;
            this.PowerConsumption = powerConsumption;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Mode = mode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ForClothingCare"/> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="size">size.</param>
        /// <param name="powerConsumption">powerConsumption.</param>
        /// <param name="manufacturer">manufacturer.</param>
        /// <param name="mode">mode.</param>
        /// <param name="plugged">plugged.</param>
        public ForClothingCare(Name name, Size size, int powerConsumption, string manufacturer, decimal price, Modes mode, bool plugged)
        {
            this.Name = name;
            this.Size = size;
            this.PowerConsumption = powerConsumption;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Mode = mode;
            this.Plugged = plugged;
        }

        /// <summary>
        ///  Gets or sets a value indicating whether gets or sets .
        /// </summary>
        public Modes Mode { get => this.mode; set => this.mode = value; }
    }
}
