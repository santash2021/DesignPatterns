using System.Reflection;

namespace DesignPatterns.FactoryMethod.Factories;

public enum MobileFactoryType
{
    Samsung,
    Nokia
}
public class LoadFactory
{
    public IMobileFactory Load(MobileFactoryType mobileFactoryType)
    {
        return mobileFactoryType switch
        {
            MobileFactoryType.Nokia => new NokiaFactory(),
            MobileFactoryType.Samsung => new SamsungFactory(),
            _ => throw new ArgumentNullException()
        };
    }
}