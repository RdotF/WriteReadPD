using PD1.Interfaces;
using System.Diagnostics;
namespace PD1;

public class ExitCommand : ICommand
{
    //internal method
    int ICommand.ExecuteCommand()
    {
        Console.WriteLine("Closing Program");
        Process.GetCurrentProcess().Kill();
        return -1;
    }
}