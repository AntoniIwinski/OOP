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

public class Book
{
    public string Title { get; private set; }
    public string Author { get; private set; }
    public int Pages { get; private set; }

    public Book(string title, string author, int pages) 
    {
        Title = title;
        Author = author;
        Pages = pages;
    }

    public void add()
    {
        this.Title = "Cursed book";
        this.Author = "anonim";
        this.Pages = 2137;
    }
    public void GetSummary()
    {
        Console.WriteLine($"Title by {Author}, pages: {Pages}");
    }
}

public class BankAccount
{
    public string OwnerName { get; private set; }
    private double Balance;
    
    public BankAccount(string ownerName, double balance)
    {
        OwnerName = ownerName;
        Balance = balance;
    }

    public void Deposit()
    {
        Console.WriteLine("O ile chcesz zwiekszyc saldo?");
        double amount = int.Parse(Console.ReadLine());
        this.Balance = this.Balance + amount;
        Console.WriteLine($"Balans konta {this.OwnerName} wynosi: {this.Balance}");
    }

    public void WithDraw()
    {
        Console.WriteLine("Podaj kwote jaka chcesz wyplacic");
        double amount = int.Parse(Console.ReadLine());
        if(this.Balance > amount)
        {
            this.Balance -= amount;
            Console.WriteLine($"Pieniadze wyplacono. Aktualny stan konta: {this.Balance}");
        }
        else
        {
            Console.WriteLine($"Niewystarczajace srodki na koncie. Aktualny balans: {this.Balance}");
        }
    }

    public void DisplayBalance()
    {
        Console.WriteLine($"Twoje akutalne saldo konta wynosi: {this.Balance}");
    }
}

public class Food(string TypeName,int EnergyGiven)
{
    public string TypeName {  get; set; } = TypeName;
    public int EnergyGiven {  get; set; } = EnergyGiven;

    public void ChangeIntoEnergy()
    {
        Random random = new Random();
        this.EnergyGiven = random.Next(6, 10);
    }
}

public class Dog(string Name, int EnergyLvl)
{
    public string Name { get; set; } = Name;
    public int EnergyLvl { get; set; } = EnergyLvl;

    public void Eat(object obj)
    {
        Console.WriteLine($"Poziom energii pieska przed zjedzeniem {this.EnergyLvl}");
        if(obj.GetType() == typeof(Food))
        {
            Food food = (Food)obj;
            this.EnergyLvl += food.EnergyGiven;
        }
        Console.WriteLine($"Poziom energii pieska: {this.EnergyLvl}");
    }
}