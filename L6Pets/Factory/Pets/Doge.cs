namespace ConsoleApp1.L6Pets.Factory.Pets;

public class Doge : Dog
{
    public override float ComplexityFactor => 2f;

    public Doge(string name) : base(name)
    {
    }
}