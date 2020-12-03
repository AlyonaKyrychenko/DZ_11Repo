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
            string separator = "_______________________\n";
            AppliationSet set1 = new AppliationSet();
            set1.AddAppliance(new Climatic(Name.Heater, Size.Large, 1500, "Saturn", 599.99M, Seasons.Winter));
            set1.AddAppliance(new ForCooking(Name.Refrigerator, Size.Large, 1200, "Indesit", 19935.00M, ByAppointment.Freezing, true));
            set1.AddAppliance(new Climatic(Name.Сonditioner, Size.Large, 1800, "Samsung", 1199.99M, Seasons.Summer, true));
            set1.AddAppliance(new Climatic(Name.Сonditioner, Size.Large, 1500, "Indesit", 899.99M, Seasons.Summer, true));

            Console.WriteLine("All your appliance:\n");
            foreach (Appliances s in set1.ApplianceArray)
            {
                Console.WriteLine($"{s.Name}: {s.Manufacturer}\nSize: {s.Size}\nPower consumption: {s.PowerConsumption} watt per hour\nPrice: {s.Price}\nPlug: {s.Plugged}\n");
            }

            Console.WriteLine(separator);

            Console.WriteLine("After sorting by price:\n");
            set1.SortByPrice();
            foreach (Appliances s in set1.ApplianceArray)
            {
                Console.WriteLine($"{s.Name}: {s.Manufacturer}\nSize: {s.Size}\nPower consumption: {s.PowerConsumption} watt per hour\nPrice: {s.Price}\nPlug: {s.Plugged}\n");
            }

            Console.WriteLine(separator);

            Console.WriteLine("After sorting by power consumption:\n");
            set1.SortByPower();
            foreach (Appliances s in set1.ApplianceArray)
            {
                Console.WriteLine($"{s.Name}: {s.Manufacturer}\nSize: {s.Size}\nPower consumption: {s.PowerConsumption} watt per hour\nPrice: {s.Price}\nPlug: {s.Plugged}\n");
            }

            Console.WriteLine(separator);

            int power = set1.CalcPower();
            Console.WriteLine($"Summ of plugged appliences = {power} per hour.");

            Console.WriteLine(separator);

            Appliances[] pluggedDevices = set1.FindApplience(true);
            if (pluggedDevices.Length == 0)
            {
                Console.WriteLine("No appliences plugged.");
            }
            else
            {
                Console.WriteLine("Plugged appliences:");
                foreach (Appliances device in pluggedDevices)
                {
                    Console.WriteLine($"{device.Name} {device.Manufacturer}");
                }
            }

            Console.WriteLine(separator);

            pluggedDevices = set1.FindApplience(true, Name.Сonditioner);
            if (pluggedDevices.Length == 0)
            {
                Console.WriteLine("No appliences plugged.");
            }
            else
            {
                Console.WriteLine("Plugged conditioners:");
                foreach (Appliances device1 in pluggedDevices)
                {
                    Console.WriteLine($"{device1.Name} {device1.Manufacturer}");
                }
            }
        }
    }
}
