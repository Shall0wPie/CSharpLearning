using ConsoleApp1.L6Pets.Factory.Pets;

namespace ConsoleApp1.L6Pets.Factory.PetCreators;

public class ShlepaCreator : IPetCreator
{
    public bool CanCreate(PetTypes petType)
    {
        return petType == PetTypes.Shlepa;
    }

    public Pet CreatePet(string name)
    {
        return new Shlepa(name);
    }
}