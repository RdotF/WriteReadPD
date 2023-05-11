using PD1.Interfaces;
using Path = WriteReadPD.Services.Path;
namespace WriteReadPD;

public class ReadCommand: ICommand
{
    private readonly IRead _read;
    public ReadCommand(IRead read)
    {
        _read = read;
    }

    //internal method
    int ICommand.ExecuteCommand()
    {   Console.WriteLine("Read from file:");
        try
        {
            Path path = new Path();
            _read.ReadFile(path.GetPath());
        }
        catch (Exception e)
        {
            Console.WriteLine("Couldn't execute command Write");
        }

        return 0;
    }
}