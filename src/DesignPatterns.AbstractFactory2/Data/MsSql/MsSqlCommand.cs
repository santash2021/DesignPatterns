using DesignPatterns.AbstractFactory2.Models;

namespace DesignPatterns.AbstractFactory2.Data.MsSql;

public class MsSqlCommand : Command
{
    public override void Execute(string query)
    {
        Console.WriteLine("MsSql command executed.");
    }
}