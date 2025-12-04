using System;

// A delegate that accepts two integers and returns an integer
public delegate int Calculate(int a, int b);

// A delegate that takes a price and returns the discounted price
public delegate double DiscountStrategy(double price);

public class DelegateTasks
{
    // ---- Methods for Calculate delegate ----

    // Adds two integers
    public static int Add(int x, int y)
    {
        return x + y;
    }

    // Subtracts two integers
    public static int Subtract(int x, int y)
    {
        return x - y;
    }

    // ---- Discount strategy methods ----

    // Festival discount gives 20% off
    public static double FestivalDiscount(double price)
    {
        return price * 0.80;  // keeping 80%
    }

    // Seasonal discount gives 10% off
    public static double SeasonalDiscount(double price)
    {
        return price * 0.90; // keeping 90%
    }

    // No discount → return same price
    public static double NoDiscount(double price)
    {
        return price;
    }

    // ---- Task 2.1: Method using DiscountStrategy delegate ----

    // This method takes the original price and applies the discount strategy
    public static double CalculateFinalPrice(double originalPrice, DiscountStrategy strategy)
    {
        return strategy(originalPrice);
    }
}
