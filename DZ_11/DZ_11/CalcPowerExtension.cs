namespace DZ_11
{
    /// <summary>
    ///  This class for calculating extension method.
    /// </summary>
    public static class CalcPowerExtension
    {
        /// <summary>
        ///  This class for calculating extension method.
        /// </summary>
        /// <returns>int power.</returns>
        /// <param name="applianceSet">list.</param>
        public static int CalcPower(this AppliationSet applianceSet)
        {
            int power = 0;
            foreach (Appliances ob in applianceSet.ApplianceList)
            {
                if (ob.Plugged)
                {
                    power += ob.PowerConsumption;
                }
            }

            return power;
        }
    }
}
