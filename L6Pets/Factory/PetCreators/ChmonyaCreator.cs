using ConsoleApp1.L6Pets.Factory.Pets;

namespace ConsoleApp1.L6Pets.Factory.PetCreators;

public class ChmonyaCreator : IPetCreator
{
    public bool CanCreate(PetTypes petType)
    {
        return petType == PetTypes.Chmonya;
    }

    public Pet CreatePet(string name)
    {
        return new Chmonya(name);
    }
}