namespace DesignPatterns.AbstractFactory.Models;

public class Samsung : IAndroidMobile
{
    public string CreateAndroidMobile()
    {
        return GetType().ToString().Split('.').Last();
    }
}