using System.Diagnostics;

Car Toyota = new Car(240);
Motorcycle Ducati = new Motorcycle(180);
Toyota.DisplayMaxSpeed(Toyota.MaxSpeed);
Ducati.DisplayMaxSpeed(Ducati.MaxSpeed);

Dog Fido = new Dog("mieszaniec");
Cat Ben = new Cat("brytyjski");
Fido.MakeSound(Fido.Race);
Ben.MakeSound(Ben.Race);

Manager Sigma = new Manager("Sigma", "Ewok", 2137, 69);
SalesPerson Wojti = new SalesPerson("Wojti", "Frajer", 1234, 321, 18);
Sigma.CalculateSalary();
Wojti.CalculateSalary();
public class Vehicle(int maxspeed)
{
    public int MaxSpeed = maxspeed;

    public void DisplayMaxSpeed(int maxspeed)
    {
        Console.WriteLine($"{this.GetType()} {maxspeed}");
    }
}

public class Car(int maxspeed) : Vehicle(maxspeed);
public class Motorcycle(int maxspeed) : Vehicle(maxspeed);


public abstract class Animal(string race)
{
    public string Race = race;
    public abstract void MakeSound(string race);
}

public class Dog(string race) : Animal(race)
{
    public override void MakeSound(string race)
    {
        Console.WriteLine($"{this.GetType()} makes Woof Woof");
    }
}

public class Cat(string race) : Animal(race)
{
    public override void MakeSound(string race)
    {
        Console.WriteLine($"{this.GetType()} makes Meow Meow");
    }
}

public class Employee(string firstname, string lastname, int basesalary)
{
    public string FirstName = firstname;
    public string LastName = lastname;
    public int BaseSalary = basesalary;

    public void CalculateSalary(int salary)
    {
        Console.WriteLine($"{this.BaseSalary}");
    }
}

public class Manager(string firstname, string lastname, int basesalary,int bonus) : Employee(firstname, lastname, basesalary)
{
    public int Bonus = bonus;

    public void CalculateSalary()
    {
        int salary = this.BaseSalary + this.Bonus;
        Console.WriteLine(salary);
    }
}

public class SalesPerson(string firstname, string lastname, int basesalary, int commision, int salesvalue): Employee(firstname, lastname, basesalary)
{
    public int Commision = commision;
    public int SalesValue = salesvalue;
    
    public void CalculateSalary()
    {
        int salary = this.BaseSalary + this.Commision + this.SalesValue;
        Console.WriteLine(salary);
    }
}