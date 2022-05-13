using DesignPatterns.FactoryMethod.Models;

namespace DesignPatterns.FactoryMethod.Factories;

public class SamsungFactory : IMobileFactory
{
    public IMobile CreateMobile()
    {
        return new Samsung();
    }
}