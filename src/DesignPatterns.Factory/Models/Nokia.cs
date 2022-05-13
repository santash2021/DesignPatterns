using DesignPatterns.Factory.Factory;

namespace DesignPatterns.Factory.Models;

public class Nokia : IMobile
{
    public string GetModel()
    {
        return GetType().ToString().Split('.').Last();
    }

    public int GetPrice()
    {
        return 50000;
    }
}