namespace DZ_11
{
    /// <summary>
    ///  This class for sorting.
    /// </summary>
    public class Sorting
    {
        /// <summary>
        ///  This class for comparing.
        /// </summary>
        /// <returns>int power.</returns>
        /// <param name="first">first price.</param>
        /// <param name="second">second price.</param>
        public static int CompareByPrice(object first, object second)
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

        /// <summary>
        ///  This class for comparing.
        /// </summary>
        /// <returns>int power.</returns>
        /// <param name="first">first PowerConsumption.</param>
        /// <param name="second">second PowerConsumption.</param>
        public static int CompareByPower(object first, object second)
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
