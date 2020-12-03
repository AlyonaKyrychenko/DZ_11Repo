namespace DZ_11
{
    /// <summary>
    ///  This class for appliances.
    /// </summary>
    public class Appliances
    {
        private string name;
        private Size size;
        private int powerConsumption;
        private string manufacturer;
        private decimal price;
        private bool plugged;

        /// <summary>
        ///  Gets or sets name.
        /// </summary>
        public string Name { get => this.name; set => this.name = value; }

        /// <summary>
        ///  Gets or sets size.
        /// </summary>
        public Size Size { get => this.size; set => this.size = value; }

        /// <summary>
        ///  Gets or sets power consumption.
        /// </summary>
        public int PowerConsumption { get => this.powerConsumption; set => this.powerConsumption = value; }

        /// <summary>
        ///  Gets or sets manufacturer.
        /// </summary>
        public string Manufacturer { get => this.manufacturer; set => this.manufacturer = value; }

        /// <summary>
        ///  Gets or sets .
        /// </summary>
        public decimal Price { get => this.price; set => this.price = value; }

        /// <summary>
        ///  Gets or sets a value indicating whether plug.
        /// </summary>
        public bool Plugged { get => this.plugged; set => this.plugged = value; }
    }
}
