using DesignPatterns.AbstractFactory2.Models;

namespace DesignPatterns.AbstractFactory2.Factories;

public class Creator
{
    private readonly Connection _connection;
    private readonly Command _command;
    public Creator(DatabaseFactory databaseFactory)
    {
        _connection = databaseFactory.CreateConnection();
        _command = databaseFactory.CreateCommand();
        Start();
    }

    private void Start()
    {
        if (_connection.State != "OPEN") return;
        _connection.Connect();
        _command.Execute("SELECT * FROM on ...");
        _connection.DisConnect();
    }
}