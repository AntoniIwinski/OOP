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

public class Student
{
    public string Name { get; private set; }

    private int _grade;
    public int Grade
    {
        get { return _grade; }
        set { if (value >= 1 && value <= 6) { _grade = value; } }
    }

    public Student(string name, int grade)
    {
        Name = name;
        Grade = grade;
    }

    public bool IsPassing()
    {
        if(Grade >= 2)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}