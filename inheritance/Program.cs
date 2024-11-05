Car Toyota = new Car(240);
Motorcycle Ducati = new Motorcycle(180);
Toyota.DisplayMaxSpeed(Toyota.MaxSpeed);
Ducati.DisplayMaxSpeed(Ducati.MaxSpeed);

Dog Fido = new Dog("mieszaniec");
Cat Ben = new Cat("brytyjski");
Fido.MakeSound(Fido.Race);
Ben.MakeSound(Ben.Race);


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