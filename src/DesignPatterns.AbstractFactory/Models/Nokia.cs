namespace DesignPatterns.AbstractFactory.Models;

public class Nokia : IAndroidMobile
{
    public string CreateAndroidMobile()
    {
        return GetType().ToString().Split('.').Last();
    }
}