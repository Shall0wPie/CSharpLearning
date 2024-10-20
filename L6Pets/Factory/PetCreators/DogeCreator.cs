using ConsoleApp1.L6Pets.Factory.Pets;

namespace ConsoleApp1.L6Pets.Factory.PetCreators;

public class DogeCreator : IPetCreator
{
    public bool CanCreate(PetTypes petType)
    {
        return petType == PetTypes.Doge;
    }

    public Pet CreatePet(string name)
    {
        return new Doge(name);
    }
}