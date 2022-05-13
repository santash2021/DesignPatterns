using DesignPatterns.Factory.Models;

namespace DesignPatterns.Factory.Factory;

public enum MobileModel
{
    Nokia,
    Samsung
}
public class MobileFactory
{
    public IMobile? GetMobile(MobileModel model)
    {
        return model switch
        {
            MobileModel.Nokia => new Nokia(),
            MobileModel.Samsung => new Samsung(),
            _ => null
        };
    }
}