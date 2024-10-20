using ConsoleApp1.L6Pets.Factory.PetCreators;
using ConsoleApp1.L6Pets.Factory.Pets;

namespace ConsoleApp1.L6Pets.Factory;

public static class PetFactory
{
    private static readonly IPetCreator[] _creators =
    {
        new ShlepaCreator(),
        new DogeCreator(),
        new ChmonyaCreator(),
        new SobakaBarabakaCreator()
    };
    
    public static Pet CreatePet(PetTypes petType, string name)
    {
        foreach (var creator in _creators)
        {
            if (creator.CanCreate(petType))
                return creator.CreatePet(name);
        }
        
        return null; 
    }
}