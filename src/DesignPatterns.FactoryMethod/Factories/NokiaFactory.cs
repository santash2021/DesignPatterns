using DesignPatterns.FactoryMethod.Models;

namespace DesignPatterns.FactoryMethod.Factories;

public class NokiaFactory : IMobileFactory
{
    public IMobile CreateMobile()
    {
        return new Nokia();
    }
}