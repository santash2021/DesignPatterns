using DesignPatterns.FactoryMethod.Models;

namespace DesignPatterns.FactoryMethod.Factories;

public interface IMobileFactory
{
    IMobile CreateMobile();
}