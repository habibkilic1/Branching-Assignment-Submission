
using System;

class QuickQuoteGenerator
{
    static void Main()
    {
        Console.WriteLine("=== PACKAGE EXPRESS QUICK QUOTE SYSTEM ===");
        Console.WriteLine("Please provide your parcel information below.
");

        Console.Write("Parcel Weight (lbs): ");
        if (!decimal.TryParse(Console.ReadLine(), out decimal weight))
        {
            Console.WriteLine("Input error: Please enter a valid weight.");
            return;
        }

        if (weight > 50)
        {
            Console.WriteLine("This parcel is too heavy for Package Express delivery.");
            return;
        }

        Console.Write("Width (inches): ");
        if (!decimal.TryParse(Console.ReadLine(), out decimal width))
        {
            Console.WriteLine("Invalid width.");
            return;
        }

        Console.Write("Height (inches): ");
        if (!decimal.TryParse(Console.ReadLine(), out decimal height))
        {
            Console.WriteLine("Invalid height.");
            return;
        }

        Console.Write("Length (inches): ");
        if (!decimal.TryParse(Console.ReadLine(), out decimal length))
        {
            Console.WriteLine("Invalid length.");
            return;
        }

        decimal totalSize = width + height + length;
        if (totalSize > 50)
        {
            Console.WriteLine("Package exceeds maximum size for shipment.");
            return;
        }

        decimal quote = (width * height * length * weight) / 100;
        Console.WriteLine($"
Quote Summary: ${quote:F2} for delivery.");
        Console.WriteLine("Thank you for using the Package Express Quick Quote System.");
    }
}
