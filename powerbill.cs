using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Power Bill Calculator!");

        // Display usage types and rates
        Console.WriteLine("Usage Types and Rates:");
        Console.WriteLine("Residential: 12.50 KES per kWh");
        Console.WriteLine("Commercial: 15.75 KES per kWh");
        Console.WriteLine("Industrial: 18.90 KES per kWh");

        // User input for power consumption
        Console.Write("\nEnter your power consumption in kWh: ");
        if (!decimal.TryParse(Console.ReadLine(), out decimal powerConsumed) || powerConsumed < 0)
        {
            Console.WriteLine("Invalid input. Please enter a valid positive number for power consumption.");
            return;
        }

        // User input for usage type
        Console.Write("Enter usage type (residential, commercial, or industrial): ");
        string usageType = Console.ReadLine().ToLower();

        // Validate usage type input
        decimal tariffRate = GetTariffRate(usageType);
        if (tariffRate == -1)
        {
            Console.WriteLine("Invalid usage type. Please enter 'residential', 'commercial', or 'industrial'.");
            return;
        }

        // Calculate bill based on consumption and tariff rates
        decimal billAmount = CalculateBill(powerConsumed, tariffRate);

        // Display bill amount
        Console.WriteLine($"\nYour monthly power bill amount is: {billAmount} KES");
        Console.WriteLine($"Breakdown: Power consumed: {powerConsumed} kWh, Tariff rate: {tariffRate} KES per kWh");
    }

    // Function to calculate the bill amount
    static decimal CalculateBill(decimal powerConsumed, decimal tariffRate)
    {
        return powerConsumed * tariffRate;
    }

    // Function to get the tariff rate based on usage type
    static decimal GetTariffRate(string usageType)
    {
        switch (usageType)
        {
            case "residential":
                return 12.50m;
            case "commercial":
                return 15.75m;
            case "industrial":
                return 18.90m;
            default:
                return -1;
        }
    }
}
