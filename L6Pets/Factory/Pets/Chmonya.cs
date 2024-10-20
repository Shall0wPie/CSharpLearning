namespace ConsoleApp1.L6Pets.Factory.Pets;

public class Chmonya : Cat
{
    public override float ComplexityFactor => 0.5f;

    public Chmonya(string name) : base(name)
    {
    }
}