using DesignPatterns.AbstractFactory.Models;

namespace DesignPatterns.AbstractFactory.Factories;

public class ButtonMobileFactory : IMobileFactory
{
    public IAndroidMobile CreateAndroidMobile()
    {
        return new Nokia();
    }

    public IIosMobile CreateIosMobile()
    {
        return new IPhone1();
    }
}