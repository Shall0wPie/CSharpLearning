using ConsoleApp1.L6Pets.Factory.Pets;

namespace ConsoleApp1.L6Pets;

public static class PriceCalculator
{
    public static float CalculatePrice(Pet pet)
    {
        if (pet is Cat cat)
            return 100 + 50 * cat.ComplexityFactor;
        
        if (pet is Dog dog)
            return 150 + 70 * dog.ComplexityFactor;

        return 0;
    }
}