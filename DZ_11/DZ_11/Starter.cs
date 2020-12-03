namespace DZ_11
{
    using System;

    /// <summary>
    ///  This class start programm.
    /// </summary>
    public class Starter
    {
        /// <summary>
        /// Run the project.
        /// </summary>
        public void Run()
        {
            AppliationSet set1 = new AppliationSet();
            set1.AddAppliance(new Climatic("Heater", Size.Large, 1500, "Saturn", 599.99M, Seasons.Winter));
            set1.AddAppliance(new ForCooking("Fridge", Size.Large, 1200, "Indesit", 19935.00M, ByAppointment.Freezing, true));
            set1.AddAppliance(new Climatic("Air conditioning", Size.Large, 1500, "Saturn", 899.99M, Seasons.Summer, true));

            Console.WriteLine("All your appliance:");
            foreach (Appliances s in set1.ApplianceList)
            {
                Console.WriteLine($"{s.Name}: {s.Manufacturer}\nSize: {s.Size}\nPower consumption: {s.PowerConsumption} watt per hour\nPrice: {s.Price}\nPlug: {s.Plugged}\n");
            }

            Console.WriteLine("\n_______________________\n");

            Console.WriteLine("After sorting by price:");
            set1.SortByPrice();
            foreach (Appliances s in set1.ApplianceList)
            {
                Console.WriteLine($"{s.Name}: {s.Manufacturer}\nSize: {s.Size}\nPower consumption: {s.PowerConsumption} watt per hour\nPrice: {s.Price}\nPlug: {s.Plugged}\n");
            }

            Console.WriteLine("\n_______________________\n");

            Console.WriteLine("After sorting by power consumption:");
            set1.SortByPower();
            foreach (Appliances s in set1.ApplianceList)
            {
                Console.WriteLine($"{s.Name}: {s.Manufacturer}\nSize: {s.Size}\nPower consumption: {s.PowerConsumption} watt per hour\nPrice: {s.Price}\nPlug: {s.Plugged}\n");
            }

            int power = set1.CalcPower();
            Console.WriteLine($"Summ of plugged appliences = {power} per hour.");
        }
    }
}
