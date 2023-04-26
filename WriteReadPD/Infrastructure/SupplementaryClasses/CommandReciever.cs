using System.Diagnostics;
using PD1.Interfaces;
using WriteReadPD;

namespace PD1;

public class CommandReceiverSingleton
{
    private readonly Reader _reader = new Reader();
    private readonly Writer _writer = new Writer();
    protected CommandReceiverSingleton() { }
    
    private static CommandReceiverSingleton _instance = null;
    public static CommandReceiverSingleton Instance()
    {
        if (_instance == null)
        {
            _instance = new CommandReceiverSingleton();
            return _instance;
        }
        else
        {
            return null;
        }
    }
    public void ReceiveCommand(string comm) {

  
    
        Dictionary<string, ICommand> parse = new Dictionary<string, ICommand>()
        {
            ["/read"] = new ReadCommand(_reader),
            ["/write"] = new WriteCommand(_writer),
            ["/exit"] = new ExitCommand()
        };
        if (string.IsNullOrWhiteSpace(comm) || !parse.ContainsKey(comm) )
        {
            Console.WriteLine("Wrong input");
        }
        else
        {
            parse[comm].ExecuteCommand(); 
        }
    }

    
};