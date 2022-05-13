using System.Reflection;
using DesignPatterns.Factory.Models;

namespace DesignPatterns.Factory.Factories;

public enum MobileModel
{
    Nokia,
    Samsung
}
public class MobileFactory
{
    public IMobile? GetMobile(MobileModel model)
    {
        var type = Assembly.GetExecutingAssembly().GetTypes().FirstOrDefault(t => t.Name == model.ToString());
        var mobileFactory = (IMobile)Activator.CreateInstance(type!)!;
        return mobileFactory;
        // return model switch
        // {
        //     MobileModel.Nokia => new Nokia(),
        //     MobileModel.Samsung => new Samsung(),
        //     _ => null
        // };
    }
}