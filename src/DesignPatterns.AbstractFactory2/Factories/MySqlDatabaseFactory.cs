using DesignPatterns.AbstractFactory2.Data.MySql;
using DesignPatterns.AbstractFactory2.Models;

namespace DesignPatterns.AbstractFactory2.Factories;

public class MySqlDatabaseFactory : DatabaseFactory
{
    public override Connection CreateConnection()
    {
        return new MySqlConnection();
    }

    public override Command CreateCommand()
    {
        return new MySqlCommand();
    }
}