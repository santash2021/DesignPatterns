using DesignPatterns.AbstractFactory2.Models;

namespace DesignPatterns.AbstractFactory2.Factories;

public abstract class DatabaseFactory
{
    public abstract Connection CreateConnection();
    public abstract Command CreateCommand();
}