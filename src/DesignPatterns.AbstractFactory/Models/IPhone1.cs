namespace DesignPatterns.AbstractFactory.Models;

public class IPhone1 : IIosMobile
{
    public string CreateIOSMobile()
    {
        return GetType().ToString().Split('.').Last();
    }
}