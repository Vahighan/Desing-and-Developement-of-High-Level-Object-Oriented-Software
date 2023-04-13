using System;

// Define the WeekDay enumeration
enum WeekDay
{
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
    Sunday
}

// Define the IceCream abstract class
abstract class IceCream
{
    public int Price { get; set; }
    public string Flavor { get; set; }

    public abstract void Serve();
}

// Define the RegularIceCream class
class RegularIceCream : IceCream
{
    public bool WithWaffle { get; set; }
    public string Topping { get; set; }
    public bool WithChocolateSprinkles { get; set; }

    public override void Serve()
    {
        Console.WriteLine("Serving Regular Ice Cream...");
        Console.WriteLine($"Flavor: {Flavor}, Price: {Price}, With Waffle: {WithWaffle}, Topping: {Topping}, With Chocolate Sprinkles: {WithChocolateSprinkles}");
    }
}

//Define the FruitIceCream class

class FruitIceCream : IceCream
{
    public bool WithWaffle { get; set; }
    public string Topping { get; set; }

    public override void Serve()
    {
        Console.WriteLine("Serving Fruit Ice Cream...");
        Console.WriteLine($"Flavor: {Flavor}, Price: {Price}, With Waffle: {WithWaffle}, Topping: {Topping}");
    }
}

// Define the Sorbet class
class Sorbet : IceCream
{
    public override void Serve()
    {
        Console.WriteLine("Serving Sorbet...");
        Console.WriteLine($"Flavor: {Flavor}, Price: {Price}");
    }
}

// Define the Gelato class
class Gelato : IceCream
{
    public bool WithChocolateSprinkles { get; set; }

    public override void Serve()
    {
        Console.WriteLine("Serving Gelato...");
        Console.WriteLine($"Flavor: {Flavor}, Price: {Price}, With Chocolate Sprinkles: {WithChocolateSprinkles}");
    }
}

// Define the IceCreamFactory abstract class
abstract class IceCreamFactory
{
    public abstract IceCream DailySpecial(WeekDay day);
}

// Define the FirstIceCreamFactory class
class FirstIceCreamFactory : IceCreamFactory
{
    public override IceCream DailySpecial(WeekDay day)
    {
        switch (day)
        {
            case WeekDay.Monday:
                return new RegularIceCream
                {
                    Flavor = "Vanilla",
                    Price = 5,
                    WithWaffle = true,
                    Topping = "Chocolate Chips",
                    WithChocolateSprinkles = true
                };
            case WeekDay.Tuesday:
                return new FruitIceCream
                {
                    Flavor = "Strawberry",
                    Price = 4,
                    WithWaffle = false,
                    Topping = "Whipped Cream"
                };
            case WeekDay.Wednesday:
                return new Gelato
                {
                    Flavor = "Pistachio",
                    Price = 6,
                    WithChocolateSprinkles = false
                };
            default:
                throw new ArgumentException("Invalid day of the week");
        }
    }
}

// Define the SecondIceCreamFactory class
class SecondIceCreamFactory : IceCreamFactory
{
    public override IceCream DailySpecial(WeekDay day)
    {
        switch (day)
        {
            case WeekDay.Thursday:
                return new RegularIceCream
                {
                    Flavor = "Chocolate",
                    Price = 5,
                    WithWaffle = true,
                    Topping = "Caramel Sauce",
                    WithChocolateSprinkles = false
                };
            case WeekDay
