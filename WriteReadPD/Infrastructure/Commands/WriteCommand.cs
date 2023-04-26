using PD1.Interfaces;
using WriteReadPD.Services;
using Path = WriteReadPD.Services.Path;


namespace WriteReadPD;

public class WriteCommand: ICommand
{
    private readonly IWrite _write;
    public WriteCommand(IWrite write)
    {
        _write = write;
    }


    public int ExecuteCommand()
    { 
        Console.WriteLine("Write in file: ");
        try
        {
            MessageFromConsole messg = new MessageFromConsole();
            Path path = new Path();
            string text = messg.GetMessgfromUser();
            if(!string.IsNullOrWhiteSpace(text)) {
                
                _write.WriteFile(text, path.GetPath());
            } else
            {
                Console.WriteLine("No input");
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("Couldn't execute command Write");
        }

        return 0;

    }
}