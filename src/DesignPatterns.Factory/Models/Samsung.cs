using DesignPatterns.Factory.Factories;

namespace DesignPatterns.Factory.Models;

public class Samsung : IMobile
{
    public string GetModel()
    {
        return GetType().ToString().Split('.').Last();
    }

    public int GetPrice()
    {
        return 30000;
    }
}