namespace excercise_Basics;

using System;

public class Car
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public int ProductionDate { get; set; }

    public Car(string brand, string model, int productiondate)
    {
        Brand = brand;
        Model = model;
        ProductionDate = productiondate;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Brand: {Brand}");
        Console.WriteLine($"Model: {Model}");
        Console.WriteLine($"Production date: {ProductionDate}");
    }
}
