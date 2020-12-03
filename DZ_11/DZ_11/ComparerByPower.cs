namespace DZ_11
{
    using System.Collections;

    /// <summary>
    ///  This class for comparing by power consumption.
    /// </summary>
    public class ComparerByPower : IComparer
    {
        /// <summary>
        ///  This class for sorting.
        /// </summary>
        /// <returns>int power concumption.</returns>
        public int Compare(object first, object second)
        {
            var x = first as Appliances;
            var y = second as Appliances;

            if (x.PowerConsumption > y.PowerConsumption)
            {
                return 1;
            }
            else if (x.PowerConsumption < y.PowerConsumption)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
