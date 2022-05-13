using DesignPatterns.AbstractFactory.Models;

namespace DesignPatterns.AbstractFactory.Factories;

public interface IMobileFactory
{
    IAndroidMobile CreateAndroidMobile();
    IIosMobile CreateIosMobile();
}