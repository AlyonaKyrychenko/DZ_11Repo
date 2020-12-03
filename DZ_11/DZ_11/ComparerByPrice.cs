namespace DZ_11
{
    using System;
    using System.Collections;

    /// <summary>
    ///  This class for comparing by price.
    /// </summary>
    public class ComparerByPrice : IComparer
    {
        /// <summary>
        ///  This class for sorting.
        /// </summary>
        /// <returns>int price.</returns>
        public int Compare(object first, object second)
        {
            var x = first as Appliances;
            var y = second as Appliances;

            if (x.Price > y.Price)
            {
                return 1;
            }
            else if (x.Price < y.Price)
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
