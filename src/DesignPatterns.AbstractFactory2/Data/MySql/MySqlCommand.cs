using DesignPatterns.AbstractFactory2.Models;

namespace DesignPatterns.AbstractFactory2.Data.MySql;

public class MySqlCommand : Command
{
    public override void Execute(string query)
    {
        Console.WriteLine("MySql command executed.");
    }
}