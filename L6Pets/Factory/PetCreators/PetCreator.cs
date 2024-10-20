using ConsoleApp1.L6Pets.Factory.Pets;

namespace ConsoleApp1.L6Pets.Factory.PetCreators;

public interface IPetCreator
{
    bool CanCreate(PetTypes petType);
    Pet CreatePet(string name);
}