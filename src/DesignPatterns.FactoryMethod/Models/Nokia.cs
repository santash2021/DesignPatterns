namespace DesignPatterns.FactoryMethod.Models;

public class Nokia : IMobile
{
    public string GetModel()
    {
        return GetType().ToString().Split('.').Last();
    }

    public int GetPrice()
    {
        return 40000;
    }
}