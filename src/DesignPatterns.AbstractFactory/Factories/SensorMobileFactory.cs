using DesignPatterns.AbstractFactory.Models;

namespace DesignPatterns.AbstractFactory.Factories;

public class SensorMobileFactory : IMobileFactory
{
    public IAndroidMobile CreateAndroidMobile()
    {
        return new Samsung();
    }

    public IIosMobile CreateIosMobile()
    {
        return new IPhone12();
    }
}