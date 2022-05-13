namespace DesignPatterns.FactoryMethod.Models;

public class Samsung : IMobile
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