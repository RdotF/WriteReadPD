namespace PD1;
using PD1.Interfaces;

public class Command
{
    private readonly ICommand _command;

    public Command(ICommand comm)
    {
        _command = comm;
    }

    public void Execute()
    {
        _command.ExecuteCommand();
    }
    
}