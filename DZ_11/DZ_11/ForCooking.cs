namespace DZ_11
{
    /// <summary>
    ///  This class for cooking.
    /// </summary>
    internal class ForCooking : Appliances
    {
        private ByAppointment appointment;

        /// <summary>
        /// Initializes a new instance of the <see cref="ForCooking"/> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="size">size.</param>
        /// <param name="powerConsumption">powerConsumption.</param>
        /// <param name="manufacturer">manufacturer.</param>
        /// <param name="appointment">appointment.</param>
        public ForCooking(string name, Size size, int powerConsumption, string manufacturer, decimal price, ByAppointment appointment)
        {
            this.Name = name;
            this.Size = size;
            this.PowerConsumption = powerConsumption;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Appointment = appointment;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ForCooking"/> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="size">size.</param>
        /// <param name="powerConsumption">powerConsumption.</param>
        /// <param name="manufacturer">manufacturer.</param>
        /// <param name="appointment">appointment.</param>
        /// <param name="plugged">plugged.</param>
        public ForCooking(string name, Size size, int powerConsumption, string manufacturer, decimal price, ByAppointment appointment, bool plugged)
        {
            this.Name = name;
            this.Size = size;
            this.PowerConsumption = powerConsumption;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Appointment = appointment;
            this.Plugged = plugged;
        }

        /// <summary>
        ///  Gets or sets a value indicating whether gets or sets .
        /// </summary>
        public ByAppointment Appointment { get => this.appointment; set => this.appointment = value; }
    }
}
