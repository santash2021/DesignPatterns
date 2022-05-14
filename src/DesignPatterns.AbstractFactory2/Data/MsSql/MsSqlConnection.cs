using DesignPatterns.AbstractFactory2.Models;

namespace DesignPatterns.AbstractFactory2.Data.MsSql;

public class MsSqlConnection : Connection
{
    public override bool Connect()
    {
        Console.WriteLine("Establishing the MsSqlConnection connection ...");
        return true;
    }

    public override bool DisConnect()
    {
        Console.WriteLine("MsSqlConnection is disconnecting");
        return false;
    }

    public override string State => "OPEN";
}