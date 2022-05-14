using DesignPatterns.AbstractFactory2.Models;

namespace DesignPatterns.AbstractFactory2.Data.MySql;

public class MySqlConnection : Connection
{
    public override bool Connect()
    {
        Console.WriteLine("Establishing the MySqlConnection connection ...");
        return true;
    }

    public override bool DisConnect()
    {
        Console.WriteLine("MySqlConnection is disconnecting");
        return false;
    }

    public override string State => "OPEN";
}