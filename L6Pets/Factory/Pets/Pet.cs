namespace ConsoleApp1.L6Pets.Factory.Pets;

public abstract class Pet
{
    public readonly string Name;
    public abstract float ComplexityFactor { get; }

    public Pet(string name)
    {
        Name = name;
    }
}