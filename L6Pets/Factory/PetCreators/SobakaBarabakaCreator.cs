using ConsoleApp1.L6Pets.Factory.Pets;

namespace ConsoleApp1.L6Pets.Factory.PetCreators;

public class SobakaBarabakaCreator : IPetCreator
{
    public bool CanCreate(PetTypes petType)
    {
        return petType == PetTypes.SobakaBarabaka;
    }

    public Pet CreatePet(string name)
    {
        return new SobakaBarabaka(name);
    }
}