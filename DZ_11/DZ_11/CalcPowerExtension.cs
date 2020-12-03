namespace DZ_11
{
    using System;

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
            foreach (Appliances ob in applianceSet.ApplianceArray)
            {
                if (ob.Plugged)
                {
                    power += ob.PowerConsumption;
                }
            }

            return power;
        }

        /// <summary>
        ///  This class for calculating extension method.
        /// </summary>
        /// <returns>int power.</returns>
        /// <param name="applianceSet">list.</param>
        public static Appliances[] FindApplience(this AppliationSet applianceSet, bool plugged)
        {
            Appliances[] result = new Appliances[0];

            foreach (Appliances ob in applianceSet.ApplianceArray)
            {
                if (ob.Plugged == plugged)
                {
                    Array.Resize(ref result, result.Length + 1);
                    result[result.Length - 1] = ob;
                }
            }

            return result;
        }

        /// <summary>
        ///  This class for calculating extension method.
        /// </summary>
        /// <returns>int power.</returns>
        /// <param name="applianceSet">list.</param>
        public static Appliances[] FindApplience(this AppliationSet applianceSet, bool plugged, Name name)
        {
            Appliances[] result = new Appliances[0];

            foreach (Appliances ob in applianceSet.ApplianceArray)
            {
                if (ob.Plugged == plugged && ob.Name == name)
                {
                    Array.Resize(ref result, result.Length + 1);
                    result[result.Length - 1] = ob;
                }
            }

            return result;
        }
    }
}
