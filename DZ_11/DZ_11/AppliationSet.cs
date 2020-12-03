namespace DZ_11
{
    using System.Collections.Generic;

    /// <summary>
    ///  This class for setting appliences.
    /// </summary>
    public class AppliationSet : ISortApplience
    {
        private List<Appliances> applianceList;

        /// <summary>
        /// Initializes a new instance of the <see cref="AppliationSet"/> class.
        /// </summary>
        public AppliationSet()
        {
            this.applianceList = new List<Appliances>();
        }

        /// <summary>
        ///  Gets or sets list.
        /// </summary>
        public List<Appliances> ApplianceList { get => this.applianceList; set => this.applianceList = value; }

        /// <summary>
        /// Add to collection.
        /// </summary>
        /// <param name="ob">object.</param>
        public void AddAppliance(Appliances ob)
        {
            this.applianceList.Add(ob);
        }

        /// <inheritdoc/>
        public void SortByPrice()
        {
            this.applianceList.Sort(Sorting.CompareByPrice);
        }

        /// <inheritdoc/>
        public void SortByPower()
        {
            this.applianceList.Sort(Sorting.CompareByPower);
        }
    }
}
