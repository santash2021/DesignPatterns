namespace DesignPatterns.AbstractFactory.Models;

public class IPhone12 : IIosMobile
{
    public string CreateIOSMobile()
    {
        return GetType().ToString().Split('.').Last();
    }
}