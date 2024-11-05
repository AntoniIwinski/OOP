Car Toyota = new Car(240);
Motorcycle Ducati = new Motorcycle(180);
Cat Ben = new Cat();
Dog Fido = new Dog();

Toyota.DisplayMaxSpeed(Toyota.MaxSpeed);
Ducati.DisplayMaxSpeed(Ducati.MaxSpeed);
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


public abstract class Animal
{
    public abstract void MakeSound();
}

public class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Woof! Woof!");
    }
}

public class Cat : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Meow! Meow!");
    }
}