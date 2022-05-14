using DesignPatterns.AbstractFactory2.Data.MsSql;
using DesignPatterns.AbstractFactory2.Models;

namespace DesignPatterns.AbstractFactory2.Factories;

public class MsSqlDatabase : DatabaseFactory
{
    public override Connection CreateConnection()
    {
        return new MsSqlConnection();
    }

    public override Command CreateCommand()
    {
        return new MsSqlCommand();
    }
}