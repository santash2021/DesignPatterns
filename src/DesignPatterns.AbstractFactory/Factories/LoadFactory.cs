namespace DesignPatterns.AbstractFactory.Factories;

public enum LoadFactoryType
{
    Sensor,
    Button
}
public class LoadFactory
{
    public IMobileFactory Load(LoadFactoryType factoryType)
    {
        return factoryType switch
        {
            LoadFactoryType.Button => new ButtonMobileFactory(),
            LoadFactoryType.Sensor => new SensorMobileFactory(),
            _ => throw new ArgumentNullException()
        };
    }
}