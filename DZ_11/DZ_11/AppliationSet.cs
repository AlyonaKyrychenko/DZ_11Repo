namespace DZ_11
{
    using System;
    using System.Collections;

    /// <summary>
    ///  This class for setting appliences.
    /// </summary>
    public class AppliationSet : ISortApplience
    {
        private Appliances[] applianceArray;

        /// <summary>
        /// Initializes a new instance of the <see cref="AppliationSet"/> class.
        /// </summary>
        public AppliationSet()
        {
            this.applianceArray = new Appliances[0];
        }

        /// <summary>
        ///  Gets or sets list.
        /// </summary>
        public Appliances[] ApplianceArray { get => this.applianceArray; set => this.applianceArray = value; }

        /// <summary>
        /// Add to collection.
        /// </summary>
        /// <param name="ob">object.</param>
        public void AddAppliance(Appliances ob)
        {
            Array.Resize(ref this.applianceArray, this.applianceArray.Length + 1);
            this.applianceArray[this.applianceArray.Length - 1] = ob;
        }

        /// <inheritdoc/>
        public void SortByPrice()
        {
            IComparer comparer = new ComparerByPrice();
            Array.Sort(this.applianceArray, 0, this.applianceArray.Length, comparer);
        }

        /// <inheritdoc/>
        public void SortByPower()
        {
            IComparer comparer = new ComparerByPower();
            Array.Sort(this.applianceArray, 0, this.applianceArray.Length, comparer);
        }
    }
}
